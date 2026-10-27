using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121A RID: 4634
	[NetMessage(EMessageId.SignActivitySignStateNotify)]
	public sealed class SignActivitySignStateNotify : IMessage<SignActivitySignStateNotify>, IMessage, IEquatable<SignActivitySignStateNotify>, IDeepCloneable<SignActivitySignStateNotify>, IBufferMessage
	{
		// Token: 0x06018B19 RID: 101145 RVA: 0x003973FE File Offset: 0x003955FE
		[NullableContext(1)]
		public static SignActivitySignStateNotify Create()
		{
			return new SignActivitySignStateNotify();
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x06018B1A RID: 101146 RVA: 0x00397405 File Offset: 0x00395605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x06018B1B RID: 101147 RVA: 0x00397408 File Offset: 0x00395608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SignActivitySignStateNotify.Descriptor;
			}
		}

		// Token: 0x06018B1C RID: 101148 RVA: 0x0039740F File Offset: 0x0039560F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify()
		{
		}

		// Token: 0x06018B1D RID: 101149 RVA: 0x00397417 File Offset: 0x00395617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify(SignActivitySignStateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this.signState_ = other.signState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B1E RID: 101150 RVA: 0x00397454 File Offset: 0x00395654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignActivitySignStateNotify Clone()
		{
			return new SignActivitySignStateNotify(this);
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x06018B1F RID: 101151 RVA: 0x0039745C File Offset: 0x0039565C
		// (set) Token: 0x06018B20 RID: 101152 RVA: 0x00397464 File Offset: 0x00395664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x06018B21 RID: 101153 RVA: 0x0039746D File Offset: 0x0039566D
		// (set) Token: 0x06018B22 RID: 101154 RVA: 0x00397475 File Offset: 0x00395675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x06018B23 RID: 101155 RVA: 0x0039747E File Offset: 0x0039567E
		// (set) Token: 0x06018B24 RID: 101156 RVA: 0x00397486 File Offset: 0x00395686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState SignState
		{
			get
			{
				return this.signState_;
			}
			set
			{
				this.signState_ = value;
			}
		}

		// Token: 0x06018B25 RID: 101157 RVA: 0x0039748F File Offset: 0x0039568F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SignActivitySignStateNotify);
		}

		// Token: 0x06018B26 RID: 101158 RVA: 0x003974A0 File Offset: 0x003956A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SignActivitySignStateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && this.SignState == other.SignState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B27 RID: 101159 RVA: 0x003974FC File Offset: 0x003956FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.SignState != SignState.Lock)
			{
				num ^= this.SignState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B28 RID: 101160 RVA: 0x00397573 File Offset: 0x00395773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B29 RID: 101161 RVA: 0x00397580 File Offset: 0x00395780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B2A RID: 101162 RVA: 0x0039758C File Offset: 0x0039578C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SignState != SignState.Lock)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.SignState);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B2B RID: 101163 RVA: 0x00397600 File Offset: 0x00395800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.SignState != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SignState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B2C RID: 101164 RVA: 0x00397670 File Offset: 0x00395870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SignActivitySignStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.SignState != SignState.Lock)
			{
				this.SignState = other.SignState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B2D RID: 101165 RVA: 0x003976D4 File Offset: 0x003958D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B2E RID: 101166 RVA: 0x003976E0 File Offset: 0x003958E0
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
					if (num != 24U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Index = input.ReadInt32();
						}
					}
					else
					{
						this.SignState = (SignState)input.ReadEnum();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040091CB RID: 37323
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091CC RID: 37324
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040091CD RID: 37325
		private int activityId_;

		// Token: 0x040091CE RID: 37326
		public const int IndexFieldNumber = 9;

		// Token: 0x040091CF RID: 37327
		private int index_;

		// Token: 0x040091D0 RID: 37328
		public const int SignStateFieldNumber = 3;

		// Token: 0x040091D1 RID: 37329
		private SignState signState_;
	}
}
