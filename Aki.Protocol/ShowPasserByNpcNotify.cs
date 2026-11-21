using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200124E RID: 4686
	[NetMessage(EMessageId.ShowPasserByNpcNotify)]
	public sealed class ShowPasserByNpcNotify : IMessage<ShowPasserByNpcNotify>, IMessage, IEquatable<ShowPasserByNpcNotify>, IDeepCloneable<ShowPasserByNpcNotify>, IBufferMessage
	{
		// Token: 0x0601904B RID: 102475 RVA: 0x003A58DE File Offset: 0x003A3ADE
		[NullableContext(1)]
		public static ShowPasserByNpcNotify Create()
		{
			return new ShowPasserByNpcNotify();
		}

		// Token: 0x1700548A RID: 21642
		// (get) Token: 0x0601904C RID: 102476 RVA: 0x003A58E5 File Offset: 0x003A3AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700548B RID: 21643
		// (get) Token: 0x0601904D RID: 102477 RVA: 0x003A58E8 File Offset: 0x003A3AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShowPasserByNpcNotify.Descriptor;
			}
		}

		// Token: 0x0601904E RID: 102478 RVA: 0x003A58EF File Offset: 0x003A3AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify()
		{
		}

		// Token: 0x0601904F RID: 102479 RVA: 0x003A5902 File Offset: 0x003A3B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify(ShowPasserByNpcNotify other) : this()
		{
			this.isHide_ = other.isHide_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019050 RID: 102480 RVA: 0x003A5938 File Offset: 0x003A3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShowPasserByNpcNotify Clone()
		{
			return new ShowPasserByNpcNotify(this);
		}

		// Token: 0x1700548C RID: 21644
		// (get) Token: 0x06019051 RID: 102481 RVA: 0x003A5940 File Offset: 0x003A3B40
		// (set) Token: 0x06019052 RID: 102482 RVA: 0x003A5948 File Offset: 0x003A3B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsHide
		{
			get
			{
				return this.isHide_;
			}
			set
			{
				this.isHide_ = value;
			}
		}

		// Token: 0x1700548D RID: 21645
		// (get) Token: 0x06019053 RID: 102483 RVA: 0x003A5951 File Offset: 0x003A3B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x06019054 RID: 102484 RVA: 0x003A5959 File Offset: 0x003A3B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShowPasserByNpcNotify);
		}

		// Token: 0x06019055 RID: 102485 RVA: 0x003A5968 File Offset: 0x003A3B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShowPasserByNpcNotify other)
		{
			return other != null && (other == this || (this.IsHide == other.IsHide && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019056 RID: 102486 RVA: 0x003A59B8 File Offset: 0x003A3BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsHide)
			{
				num ^= this.IsHide.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019057 RID: 102487 RVA: 0x003A5A05 File Offset: 0x003A3C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019058 RID: 102488 RVA: 0x003A5A12 File Offset: 0x003A3C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019059 RID: 102489 RVA: 0x003A5A1C File Offset: 0x003A3C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsHide)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsHide);
			}
			this.entityIds_.WriteTo(ref output, ShowPasserByNpcNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601905A RID: 102490 RVA: 0x003A5A6C File Offset: 0x003A3C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsHide)
			{
				num += 2;
			}
			num += this.entityIds_.CalculateSize(ShowPasserByNpcNotify._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601905B RID: 102491 RVA: 0x003A5AB4 File Offset: 0x003A3CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShowPasserByNpcNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsHide)
			{
				this.IsHide = other.IsHide;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601905C RID: 102492 RVA: 0x003A5B01 File Offset: 0x003A3D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601905D RID: 102493 RVA: 0x003A5B0C File Offset: 0x003A3D0C
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
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.entityIds_.AddEntriesFrom(ref input, ShowPasserByNpcNotify._repeated_entityIds_codec);
					}
				}
				else
				{
					this.IsHide = input.ReadBool();
				}
			}
		}

		// Token: 0x0400944F RID: 37967
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009450 RID: 37968
		public const int IsHideFieldNumber = 5;

		// Token: 0x04009451 RID: 37969
		private bool isHide_;

		// Token: 0x04009452 RID: 37970
		public const int EntityIdsFieldNumber = 6;

		// Token: 0x04009453 RID: 37971
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(50U);

		// Token: 0x04009454 RID: 37972
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
