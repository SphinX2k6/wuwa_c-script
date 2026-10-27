using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000748 RID: 1864
	[NetMessage(EMessageId.HarvestActivityResultNotify)]
	public sealed class HarvestActivityResultNotify : IMessage<HarvestActivityResultNotify>, IMessage, IEquatable<HarvestActivityResultNotify>, IDeepCloneable<HarvestActivityResultNotify>, IBufferMessage
	{
		// Token: 0x0600A8CE RID: 43214 RVA: 0x00196022 File Offset: 0x00194222
		[NullableContext(1)]
		public static HarvestActivityResultNotify Create()
		{
			return new HarvestActivityResultNotify();
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600A8CF RID: 43215 RVA: 0x00196029 File Offset: 0x00194229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x0019602C File Offset: 0x0019422C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultNotify.Descriptor;
			}
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x00196033 File Offset: 0x00194233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify()
		{
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x0019603C File Offset: 0x0019423C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify(HarvestActivityResultNotify other) : this()
		{
			this.succ_ = other.succ_;
			this.curPoint_ = other.curPoint_;
			this.hisPoint_ = other.hisPoint_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x00196090 File Offset: 0x00194290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify Clone()
		{
			return new HarvestActivityResultNotify(this);
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x00196098 File Offset: 0x00194298
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x001960A0 File Offset: 0x001942A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x001960A9 File Offset: 0x001942A9
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x001960B1 File Offset: 0x001942B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x001960BA File Offset: 0x001942BA
		// (set) Token: 0x0600A8D9 RID: 43225 RVA: 0x001960C2 File Offset: 0x001942C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HisPoint
		{
			get
			{
				return this.hisPoint_;
			}
			set
			{
				this.hisPoint_ = value;
			}
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600A8DA RID: 43226 RVA: 0x001960CB File Offset: 0x001942CB
		// (set) Token: 0x0600A8DB RID: 43227 RVA: 0x001960D3 File Offset: 0x001942D3
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

		// Token: 0x0600A8DC RID: 43228 RVA: 0x001960DC File Offset: 0x001942DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultNotify);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x001960EC File Offset: 0x001942EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultNotify other)
		{
			return other != null && (other == this || (this.Succ == other.Succ && this.CurPoint == other.CurPoint && this.HisPoint == other.HisPoint && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x00196158 File Offset: 0x00194358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.HisPoint != 0)
			{
				num ^= this.HisPoint.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x001961E8 File Offset: 0x001943E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x001961F5 File Offset: 0x001943F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x00196200 File Offset: 0x00194400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HisPoint != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HisPoint);
			}
			if (this.Succ)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Succ);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x00196294 File Offset: 0x00194494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Succ)
			{
				num += 2;
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.HisPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HisPoint);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x00196310 File Offset: 0x00194510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.HisPoint != 0)
			{
				this.HisPoint = other.HisPoint;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x00196388 File Offset: 0x00194588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x00196394 File Offset: 0x00194594
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
				if (num <= 72U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.HisPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CF0 RID: 19696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CF1 RID: 19697
		public const int SuccFieldNumber = 12;

		// Token: 0x04004CF2 RID: 19698
		private bool succ_;

		// Token: 0x04004CF3 RID: 19699
		public const int CurPointFieldNumber = 14;

		// Token: 0x04004CF4 RID: 19700
		private int curPoint_;

		// Token: 0x04004CF5 RID: 19701
		public const int HisPointFieldNumber = 9;

		// Token: 0x04004CF6 RID: 19702
		private int hisPoint_;

		// Token: 0x04004CF7 RID: 19703
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004CF8 RID: 19704
		private ErrorCode errorCode_;
	}
}
