using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100F RID: 4111
	[NetMessage(EMessageId.RogueTowerTrialResultNotify)]
	public sealed class RogueTowerTrialResultNotify : IMessage<RogueTowerTrialResultNotify>, IMessage, IEquatable<RogueTowerTrialResultNotify>, IDeepCloneable<RogueTowerTrialResultNotify>, IBufferMessage
	{
		// Token: 0x06016021 RID: 90145 RVA: 0x00333861 File Offset: 0x00331A61
		[NullableContext(1)]
		public static RogueTowerTrialResultNotify Create()
		{
			return new RogueTowerTrialResultNotify();
		}

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x06016022 RID: 90146 RVA: 0x00333868 File Offset: 0x00331A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x06016023 RID: 90147 RVA: 0x0033386B File Offset: 0x00331A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialResultNotify.Descriptor;
			}
		}

		// Token: 0x06016024 RID: 90148 RVA: 0x00333872 File Offset: 0x00331A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify()
		{
		}

		// Token: 0x06016025 RID: 90149 RVA: 0x0033387C File Offset: 0x00331A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify(RogueTowerTrialResultNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueTowerTrialResultInfo_ = ((other.rogueTowerTrialResultInfo_ != null) ? other.rogueTowerTrialResultInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016026 RID: 90150 RVA: 0x003338C8 File Offset: 0x00331AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultNotify Clone()
		{
			return new RogueTowerTrialResultNotify(this);
		}

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x06016027 RID: 90151 RVA: 0x003338D0 File Offset: 0x00331AD0
		// (set) Token: 0x06016028 RID: 90152 RVA: 0x003338D8 File Offset: 0x00331AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x06016029 RID: 90153 RVA: 0x003338E1 File Offset: 0x00331AE1
		// (set) Token: 0x0601602A RID: 90154 RVA: 0x003338E9 File Offset: 0x00331AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialResultInfo RogueTowerTrialResultInfo
		{
			get
			{
				return this.rogueTowerTrialResultInfo_;
			}
			set
			{
				this.rogueTowerTrialResultInfo_ = value;
			}
		}

		// Token: 0x0601602B RID: 90155 RVA: 0x003338F2 File Offset: 0x00331AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialResultNotify);
		}

		// Token: 0x0601602C RID: 90156 RVA: 0x00333900 File Offset: 0x00331B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialResultNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueTowerTrialResultInfo, other.RogueTowerTrialResultInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601602D RID: 90157 RVA: 0x00333950 File Offset: 0x00331B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				num ^= this.RogueTowerTrialResultInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601602E RID: 90158 RVA: 0x003339AB File Offset: 0x00331BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601602F RID: 90159 RVA: 0x003339B8 File Offset: 0x00331BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016030 RID: 90160 RVA: 0x003339C4 File Offset: 0x00331BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueTowerTrialResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016031 RID: 90161 RVA: 0x00333A20 File Offset: 0x00331C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rogueTowerTrialResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTowerTrialResultInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016032 RID: 90162 RVA: 0x00333A78 File Offset: 0x00331C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rogueTowerTrialResultInfo_ != null)
			{
				if (this.rogueTowerTrialResultInfo_ == null)
				{
					this.RogueTowerTrialResultInfo = new RogueTowerTrialResultInfo();
				}
				this.RogueTowerTrialResultInfo.MergeFrom(other.RogueTowerTrialResultInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016033 RID: 90163 RVA: 0x00333AE0 File Offset: 0x00331CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016034 RID: 90164 RVA: 0x00333AEC File Offset: 0x00331CEC
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
				if (num != 32U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueTowerTrialResultInfo_ == null)
						{
							this.RogueTowerTrialResultInfo = new RogueTowerTrialResultInfo();
						}
						input.ReadMessage(this.RogueTowerTrialResultInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400846D RID: 33901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400846E RID: 33902
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400846F RID: 33903
		private ErrorCode errorCode_;

		// Token: 0x04008470 RID: 33904
		public const int RogueTowerTrialResultInfoFieldNumber = 10;

		// Token: 0x04008471 RID: 33905
		private RogueTowerTrialResultInfo rogueTowerTrialResultInfo_;
	}
}
