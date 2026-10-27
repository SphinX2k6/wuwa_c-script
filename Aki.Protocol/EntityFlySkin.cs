using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048D RID: 1165
	public sealed class EntityFlySkin : IMessage<EntityFlySkin>, IMessage, IEquatable<EntityFlySkin>, IDeepCloneable<EntityFlySkin>, IBufferMessage
	{
		// Token: 0x06006F6C RID: 28524 RVA: 0x0011186D File Offset: 0x0010FA6D
		[NullableContext(1)]
		public static EntityFlySkin Create()
		{
			return new EntityFlySkin();
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x00111874 File Offset: 0x0010FA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityFlySkin> Parser
		{
			get
			{
				return EntityFlySkin._parser;
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06006F6E RID: 28526 RVA: 0x0011187B File Offset: 0x0010FA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06006F6F RID: 28527 RVA: 0x0011187E File Offset: 0x0010FA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFlySkin.Descriptor;
			}
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00111885 File Offset: 0x0010FA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin()
		{
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x00111898 File Offset: 0x0010FA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin(EntityFlySkin other) : this()
		{
			this.entityId_ = other.entityId_;
			this.skinInfos_ = other.skinInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x001118CE File Offset: 0x0010FACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFlySkin Clone()
		{
			return new EntityFlySkin(this);
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x06006F73 RID: 28531 RVA: 0x001118D6 File Offset: 0x0010FAD6
		// (set) Token: 0x06006F74 RID: 28532 RVA: 0x001118DE File Offset: 0x0010FADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x06006F75 RID: 28533 RVA: 0x001118E7 File Offset: 0x0010FAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlySkinInfo> SkinInfos
		{
			get
			{
				return this.skinInfos_;
			}
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x001118EF File Offset: 0x0010FAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFlySkin);
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00111900 File Offset: 0x0010FB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFlySkin other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.skinInfos_.Equals(other.skinInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00111950 File Offset: 0x0010FB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.skinInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x0011199D File Offset: 0x0010FB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x001119AA File Offset: 0x0010FBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x001119B4 File Offset: 0x0010FBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.skinInfos_.WriteTo(ref output, EntityFlySkin._repeated_skinInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x00111A04 File Offset: 0x0010FC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.skinInfos_.CalculateSize(EntityFlySkin._repeated_skinInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x00111A58 File Offset: 0x0010FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFlySkin other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.skinInfos_.Add(other.skinInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00111AA5 File Offset: 0x0010FCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00111AB0 File Offset: 0x0010FCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.skinInfos_.AddEntriesFrom(ref input, EntityFlySkin._repeated_skinInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BEB RID: 15339
		private static readonly MessageParser<EntityFlySkin> _parser = new MessageParser<EntityFlySkin>(() => new EntityFlySkin());

		// Token: 0x04003BEC RID: 15340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BED RID: 15341
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003BEE RID: 15342
		private long entityId_;

		// Token: 0x04003BEF RID: 15343
		public const int SkinInfosFieldNumber = 2;

		// Token: 0x04003BF0 RID: 15344
		private static readonly FieldCodec<FlySkinInfo> _repeated_skinInfos_codec = FieldCodec.ForMessage<FlySkinInfo>(18U, FlySkinInfo.Parser);

		// Token: 0x04003BF1 RID: 15345
		private readonly RepeatedField<FlySkinInfo> skinInfos_ = new RepeatedField<FlySkinInfo>();
	}
}
