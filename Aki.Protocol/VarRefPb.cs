using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153D RID: 5437
	public sealed class VarRefPb : IMessage<VarRefPb>, IMessage, IEquatable<VarRefPb>, IDeepCloneable<VarRefPb>, IBufferMessage
	{
		// Token: 0x0601CCE2 RID: 117986 RVA: 0x0042CB46 File Offset: 0x0042AD46
		[NullableContext(1)]
		public static VarRefPb Create()
		{
			return new VarRefPb();
		}

		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x0601CCE3 RID: 117987 RVA: 0x0042CB4D File Offset: 0x0042AD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x0601CCE4 RID: 117988 RVA: 0x0042CB50 File Offset: 0x0042AD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarRefPb.Descriptor;
			}
		}

		// Token: 0x0601CCE5 RID: 117989 RVA: 0x0042CB57 File Offset: 0x0042AD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb()
		{
		}

		// Token: 0x0601CCE6 RID: 117990 RVA: 0x0042CB60 File Offset: 0x0042AD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb(VarRefPb other) : this()
		{
			this.sourceType_ = other.sourceType_;
			switch (other.VarRefCase)
			{
			case VarRefPb.VarRefOneofCase.ConstVarRef:
				this.ConstVarRef = other.ConstVarRef.Clone();
				break;
			case VarRefPb.VarRefOneofCase.SelfVarRef:
				this.SelfVarRef = other.SelfVarRef.Clone();
				break;
			case VarRefPb.VarRefOneofCase.GlobalVarRef:
				this.GlobalVarRef = other.GlobalVarRef.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CCE7 RID: 117991 RVA: 0x0042CBE4 File Offset: 0x0042ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb Clone()
		{
			return new VarRefPb(this);
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x0601CCE8 RID: 117992 RVA: 0x0042CBEC File Offset: 0x0042ADEC
		// (set) Token: 0x0601CCE9 RID: 117993 RVA: 0x0042CBF4 File Offset: 0x0042ADF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourceType
		{
			get
			{
				return this.sourceType_;
			}
			set
			{
				this.sourceType_ = value;
			}
		}

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x0601CCEA RID: 117994 RVA: 0x0042CBFD File Offset: 0x0042ADFD
		// (set) Token: 0x0601CCEB RID: 117995 RVA: 0x0042CC15 File Offset: 0x0042AE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstVarRefPb ConstVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.ConstVarRef)
				{
					return null;
				}
				return (ConstVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.ConstVarRef);
			}
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x0601CCEC RID: 117996 RVA: 0x0042CC2B File Offset: 0x0042AE2B
		// (set) Token: 0x0601CCED RID: 117997 RVA: 0x0042CC43 File Offset: 0x0042AE43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelfVarRefPb SelfVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.SelfVarRef)
				{
					return null;
				}
				return (SelfVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.SelfVarRef);
			}
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x0601CCEE RID: 117998 RVA: 0x0042CC59 File Offset: 0x0042AE59
		// (set) Token: 0x0601CCEF RID: 117999 RVA: 0x0042CC71 File Offset: 0x0042AE71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GlobalVarRefPb GlobalVarRef
		{
			get
			{
				if (this.varRefCase_ != VarRefPb.VarRefOneofCase.GlobalVarRef)
				{
					return null;
				}
				return (GlobalVarRefPb)this.varRef_;
			}
			set
			{
				this.varRef_ = value;
				this.varRefCase_ = ((value == null) ? VarRefPb.VarRefOneofCase.None : VarRefPb.VarRefOneofCase.GlobalVarRef);
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x0601CCF0 RID: 118000 RVA: 0x0042CC87 File Offset: 0x0042AE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarRefPb.VarRefOneofCase VarRefCase
		{
			get
			{
				return this.varRefCase_;
			}
		}

		// Token: 0x0601CCF1 RID: 118001 RVA: 0x0042CC8F File Offset: 0x0042AE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearVarRef()
		{
			this.varRefCase_ = VarRefPb.VarRefOneofCase.None;
			this.varRef_ = null;
		}

		// Token: 0x0601CCF2 RID: 118002 RVA: 0x0042CC9F File Offset: 0x0042AE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarRefPb);
		}

		// Token: 0x0601CCF3 RID: 118003 RVA: 0x0042CCB0 File Offset: 0x0042AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarRefPb other)
		{
			return other != null && (other == this || (this.SourceType == other.SourceType && object.Equals(this.ConstVarRef, other.ConstVarRef) && object.Equals(this.SelfVarRef, other.SelfVarRef) && object.Equals(this.GlobalVarRef, other.GlobalVarRef) && this.VarRefCase == other.VarRefCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CCF4 RID: 118004 RVA: 0x0042CD38 File Offset: 0x0042AF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SourceType != 0)
			{
				num ^= this.SourceType.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				num ^= this.ConstVarRef.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				num ^= this.SelfVarRef.GetHashCode();
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				num ^= this.GlobalVarRef.GetHashCode();
			}
			num ^= (int)this.varRefCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CCF5 RID: 118005 RVA: 0x0042CDC5 File Offset: 0x0042AFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CCF6 RID: 118006 RVA: 0x0042CDD2 File Offset: 0x0042AFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CCF7 RID: 118007 RVA: 0x0042CDDC File Offset: 0x0042AFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SourceType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SourceType);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ConstVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SelfVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GlobalVarRef);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CCF8 RID: 118008 RVA: 0x0042CE70 File Offset: 0x0042B070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SourceType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourceType);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ConstVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfVarRef);
			}
			if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GlobalVarRef);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CCF9 RID: 118009 RVA: 0x0042CEFC File Offset: 0x0042B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VarRefPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SourceType != 0)
			{
				this.SourceType = other.SourceType;
			}
			switch (other.VarRefCase)
			{
			case VarRefPb.VarRefOneofCase.ConstVarRef:
				if (this.ConstVarRef == null)
				{
					this.ConstVarRef = new ConstVarRefPb();
				}
				this.ConstVarRef.MergeFrom(other.ConstVarRef);
				break;
			case VarRefPb.VarRefOneofCase.SelfVarRef:
				if (this.SelfVarRef == null)
				{
					this.SelfVarRef = new SelfVarRefPb();
				}
				this.SelfVarRef.MergeFrom(other.SelfVarRef);
				break;
			case VarRefPb.VarRefOneofCase.GlobalVarRef:
				if (this.GlobalVarRef == null)
				{
					this.GlobalVarRef = new GlobalVarRefPb();
				}
				this.GlobalVarRef.MergeFrom(other.GlobalVarRef);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CCFA RID: 118010 RVA: 0x0042CFC5 File Offset: 0x0042B1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CCFB RID: 118011 RVA: 0x0042CFD0 File Offset: 0x0042B1D0
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.SourceType = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						ConstVarRefPb constVarRefPb = new ConstVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.ConstVarRef)
						{
							constVarRefPb.MergeFrom(this.ConstVarRef);
						}
						input.ReadMessage(constVarRefPb);
						this.ConstVarRef = constVarRefPb;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						SelfVarRefPb selfVarRefPb = new SelfVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.SelfVarRef)
						{
							selfVarRefPb.MergeFrom(this.SelfVarRef);
						}
						input.ReadMessage(selfVarRefPb);
						this.SelfVarRef = selfVarRefPb;
						continue;
					}
					if (num == 34U)
					{
						GlobalVarRefPb globalVarRefPb = new GlobalVarRefPb();
						if (this.varRefCase_ == VarRefPb.VarRefOneofCase.GlobalVarRef)
						{
							globalVarRefPb.MergeFrom(this.GlobalVarRef);
						}
						input.ReadMessage(globalVarRefPb);
						this.GlobalVarRef = globalVarRefPb;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A5CB RID: 42443
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5CC RID: 42444
		public const int SourceTypeFieldNumber = 1;

		// Token: 0x0400A5CD RID: 42445
		private int sourceType_;

		// Token: 0x0400A5CE RID: 42446
		public const int ConstVarRefFieldNumber = 2;

		// Token: 0x0400A5CF RID: 42447
		public const int SelfVarRefFieldNumber = 3;

		// Token: 0x0400A5D0 RID: 42448
		public const int GlobalVarRefFieldNumber = 4;

		// Token: 0x0400A5D1 RID: 42449
		private object varRef_;

		// Token: 0x0400A5D2 RID: 42450
		private VarRefPb.VarRefOneofCase varRefCase_;

		// Token: 0x02001A8F RID: 6799
		public enum VarRefOneofCase
		{
			// Token: 0x0400D03F RID: 53311
			None,
			// Token: 0x0400D040 RID: 53312
			ConstVarRef = 2,
			// Token: 0x0400D041 RID: 53313
			SelfVarRef,
			// Token: 0x0400D042 RID: 53314
			GlobalVarRef
		}
	}
}
