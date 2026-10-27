using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000645 RID: 1605
	public sealed class FRDebugActionInfo : IMessage<FRDebugActionInfo>, IMessage, IEquatable<FRDebugActionInfo>, IDeepCloneable<FRDebugActionInfo>, IBufferMessage
	{
		// Token: 0x060093BF RID: 37823 RVA: 0x001653F5 File Offset: 0x001635F5
		[NullableContext(1)]
		public static FRDebugActionInfo Create()
		{
			return new FRDebugActionInfo();
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060093C0 RID: 37824 RVA: 0x001653FC File Offset: 0x001635FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x001653FF File Offset: 0x001635FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRDebugActionInfo.Descriptor;
			}
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x00165406 File Offset: 0x00163606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo()
		{
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00165424 File Offset: 0x00163624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo(FRDebugActionInfo other) : this()
		{
			this.actionId_ = other.actionId_;
			this.targetIncId_ = other.targetIncId_.Clone();
			this.exInfo_ = other.exInfo_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x00165471 File Offset: 0x00163671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRDebugActionInfo Clone()
		{
			return new FRDebugActionInfo(this);
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00165479 File Offset: 0x00163679
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00165481 File Offset: 0x00163681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x0016548A File Offset: 0x0016368A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TargetIncId
		{
			get
			{
				return this.targetIncId_;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060093C8 RID: 37832 RVA: 0x00165492 File Offset: 0x00163692
		// (set) Token: 0x060093C9 RID: 37833 RVA: 0x0016549A File Offset: 0x0016369A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ExInfo
		{
			get
			{
				return this.exInfo_;
			}
			set
			{
				this.exInfo_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x001654AD File Offset: 0x001636AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRDebugActionInfo);
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x001654BC File Offset: 0x001636BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRDebugActionInfo other)
		{
			return other != null && (other == this || (this.ActionId == other.ActionId && this.targetIncId_.Equals(other.targetIncId_) && !(this.ExInfo != other.ExInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x00165520 File Offset: 0x00163720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			num ^= this.targetIncId_.GetHashCode();
			if (this.ExInfo.Length != 0)
			{
				num ^= this.ExInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x00165588 File Offset: 0x00163788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x00165595 File Offset: 0x00163795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x001655A0 File Offset: 0x001637A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActionId);
			}
			this.targetIncId_.WriteTo(ref output, FRDebugActionInfo._repeated_targetIncId_codec);
			if (this.ExInfo.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ExInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00165610 File Offset: 0x00163810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			num += this.targetIncId_.CalculateSize(FRDebugActionInfo._repeated_targetIncId_codec);
			if (this.ExInfo.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ExInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x00165680 File Offset: 0x00163880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRDebugActionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			this.targetIncId_.Add(other.targetIncId_);
			if (other.ExInfo.Length != 0)
			{
				this.ExInfo = other.ExInfo;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x001656E6 File Offset: 0x001638E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x001656F0 File Offset: 0x001638F0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_45;
					}
					if (num == 26U)
					{
						this.ExInfo = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.targetIncId_.AddEntriesFrom(ref input, FRDebugActionInfo._repeated_targetIncId_codec);
			}
		}

		// Token: 0x040046F8 RID: 18168
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046F9 RID: 18169
		public const int ActionIdFieldNumber = 1;

		// Token: 0x040046FA RID: 18170
		private int actionId_;

		// Token: 0x040046FB RID: 18171
		public const int TargetIncIdFieldNumber = 2;

		// Token: 0x040046FC RID: 18172
		private static readonly FieldCodec<int> _repeated_targetIncId_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040046FD RID: 18173
		private readonly RepeatedField<int> targetIncId_ = new RepeatedField<int>();

		// Token: 0x040046FE RID: 18174
		public const int ExInfoFieldNumber = 3;

		// Token: 0x040046FF RID: 18175
		private string exInfo_ = "";
	}
}
