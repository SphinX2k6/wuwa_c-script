using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC5 RID: 3525
	public sealed class PoisonCircleSnapshotInfo : IMessage<PoisonCircleSnapshotInfo>, IMessage, IEquatable<PoisonCircleSnapshotInfo>, IDeepCloneable<PoisonCircleSnapshotInfo>, IBufferMessage
	{
		// Token: 0x06012FB5 RID: 77749 RVA: 0x002C472D File Offset: 0x002C292D
		[NullableContext(1)]
		public static PoisonCircleSnapshotInfo Create()
		{
			return new PoisonCircleSnapshotInfo();
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x06012FB6 RID: 77750 RVA: 0x002C4734 File Offset: 0x002C2934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x06012FB7 RID: 77751 RVA: 0x002C4737 File Offset: 0x002C2937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PoisonCircleSnapshotInfo.Descriptor;
			}
		}

		// Token: 0x06012FB8 RID: 77752 RVA: 0x002C473E File Offset: 0x002C293E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo()
		{
		}

		// Token: 0x06012FB9 RID: 77753 RVA: 0x002C4746 File Offset: 0x002C2946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo(PoisonCircleSnapshotInfo other) : this()
		{
			this.poisonCircleId_ = other.poisonCircleId_;
			this.isDayEndPoisonCircle_ = other.isDayEndPoisonCircle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FBA RID: 77754 RVA: 0x002C4777 File Offset: 0x002C2977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo Clone()
		{
			return new PoisonCircleSnapshotInfo(this);
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x06012FBB RID: 77755 RVA: 0x002C477F File Offset: 0x002C297F
		// (set) Token: 0x06012FBC RID: 77756 RVA: 0x002C4787 File Offset: 0x002C2987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PoisonCircleId
		{
			get
			{
				return this.poisonCircleId_;
			}
			set
			{
				this.poisonCircleId_ = value;
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x06012FBD RID: 77757 RVA: 0x002C4790 File Offset: 0x002C2990
		// (set) Token: 0x06012FBE RID: 77758 RVA: 0x002C4798 File Offset: 0x002C2998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDayEndPoisonCircle
		{
			get
			{
				return this.isDayEndPoisonCircle_;
			}
			set
			{
				this.isDayEndPoisonCircle_ = value;
			}
		}

		// Token: 0x06012FBF RID: 77759 RVA: 0x002C47A1 File Offset: 0x002C29A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PoisonCircleSnapshotInfo);
		}

		// Token: 0x06012FC0 RID: 77760 RVA: 0x002C47AF File Offset: 0x002C29AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PoisonCircleSnapshotInfo other)
		{
			return other != null && (other == this || (this.PoisonCircleId == other.PoisonCircleId && this.IsDayEndPoisonCircle == other.IsDayEndPoisonCircle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FC1 RID: 77761 RVA: 0x002C47F0 File Offset: 0x002C29F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PoisonCircleId != 0)
			{
				num ^= this.PoisonCircleId.GetHashCode();
			}
			if (this.IsDayEndPoisonCircle)
			{
				num ^= this.IsDayEndPoisonCircle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012FC2 RID: 77762 RVA: 0x002C4848 File Offset: 0x002C2A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FC3 RID: 77763 RVA: 0x002C4855 File Offset: 0x002C2A55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FC4 RID: 77764 RVA: 0x002C4860 File Offset: 0x002C2A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PoisonCircleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PoisonCircleId);
			}
			if (this.IsDayEndPoisonCircle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsDayEndPoisonCircle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FC5 RID: 77765 RVA: 0x002C48B8 File Offset: 0x002C2AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PoisonCircleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PoisonCircleId);
			}
			if (this.IsDayEndPoisonCircle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012FC6 RID: 77766 RVA: 0x002C4904 File Offset: 0x002C2B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PoisonCircleSnapshotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PoisonCircleId != 0)
			{
				this.PoisonCircleId = other.PoisonCircleId;
			}
			if (other.IsDayEndPoisonCircle)
			{
				this.IsDayEndPoisonCircle = other.IsDayEndPoisonCircle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012FC7 RID: 77767 RVA: 0x002C4954 File Offset: 0x002C2B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FC8 RID: 77768 RVA: 0x002C4960 File Offset: 0x002C2B60
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsDayEndPoisonCircle = input.ReadBool();
					}
				}
				else
				{
					this.PoisonCircleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400754C RID: 30028
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400754D RID: 30029
		public const int PoisonCircleIdFieldNumber = 1;

		// Token: 0x0400754E RID: 30030
		private int poisonCircleId_;

		// Token: 0x0400754F RID: 30031
		public const int IsDayEndPoisonCircleFieldNumber = 2;

		// Token: 0x04007550 RID: 30032
		private bool isDayEndPoisonCircle_;
	}
}
