using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AD RID: 5293
	[NetMessage(EMessageId.UpdateSysBuffNotify)]
	public sealed class UpdateSysBuffNotify : IMessage<UpdateSysBuffNotify>, IMessage, IEquatable<UpdateSysBuffNotify>, IDeepCloneable<UpdateSysBuffNotify>, IBufferMessage
	{
		// Token: 0x0601BFDB RID: 114651 RVA: 0x0040B999 File Offset: 0x00409B99
		[NullableContext(1)]
		public static UpdateSysBuffNotify Create()
		{
			return new UpdateSysBuffNotify();
		}

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0601BFDC RID: 114652 RVA: 0x0040B9A0 File Offset: 0x00409BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x0601BFDD RID: 114653 RVA: 0x0040B9A3 File Offset: 0x00409BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x0040B9AA File Offset: 0x00409BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify()
		{
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x0040B9BD File Offset: 0x00409BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify(UpdateSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.buffInfos_ = other.buffInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFE0 RID: 114656 RVA: 0x0040B9F3 File Offset: 0x00409BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSysBuffNotify Clone()
		{
			return new UpdateSysBuffNotify(this);
		}

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x0601BFE1 RID: 114657 RVA: 0x0040B9FB File Offset: 0x00409BFB
		// (set) Token: 0x0601BFE2 RID: 114658 RVA: 0x0040BA03 File Offset: 0x00409C03
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

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x0601BFE3 RID: 114659 RVA: 0x0040BA0C File Offset: 0x00409C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SysBuffInformation> BuffInfos
		{
			get
			{
				return this.buffInfos_;
			}
		}

		// Token: 0x0601BFE4 RID: 114660 RVA: 0x0040BA14 File Offset: 0x00409C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSysBuffNotify);
		}

		// Token: 0x0601BFE5 RID: 114661 RVA: 0x0040BA24 File Offset: 0x00409C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.buffInfos_.Equals(other.buffInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFE6 RID: 114662 RVA: 0x0040BA74 File Offset: 0x00409C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.buffInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFE7 RID: 114663 RVA: 0x0040BAC1 File Offset: 0x00409CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFE8 RID: 114664 RVA: 0x0040BACE File Offset: 0x00409CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BFE9 RID: 114665 RVA: 0x0040BAD8 File Offset: 0x00409CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			this.buffInfos_.WriteTo(ref output, UpdateSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BFEA RID: 114666 RVA: 0x0040BB28 File Offset: 0x00409D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.buffInfos_.CalculateSize(UpdateSysBuffNotify._repeated_buffInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BFEB RID: 114667 RVA: 0x0040BB7C File Offset: 0x00409D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSysBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.buffInfos_.Add(other.buffInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BFEC RID: 114668 RVA: 0x0040BBC9 File Offset: 0x00409DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BFED RID: 114669 RVA: 0x0040BBD4 File Offset: 0x00409DD4
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
				if (num != 40U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffInfos_.AddEntriesFrom(ref input, UpdateSysBuffNotify._repeated_buffInfos_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A0C4 RID: 41156
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0C5 RID: 41157
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400A0C6 RID: 41158
		private long entityId_;

		// Token: 0x0400A0C7 RID: 41159
		public const int BuffInfosFieldNumber = 11;

		// Token: 0x0400A0C8 RID: 41160
		private static readonly FieldCodec<SysBuffInformation> _repeated_buffInfos_codec = FieldCodec.ForMessage<SysBuffInformation>(90U, SysBuffInformation.Parser);

		// Token: 0x0400A0C9 RID: 41161
		private readonly RepeatedField<SysBuffInformation> buffInfos_ = new RepeatedField<SysBuffInformation>();
	}
}
