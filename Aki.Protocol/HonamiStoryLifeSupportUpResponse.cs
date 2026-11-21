using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000772 RID: 1906
	[NetMessage(EMessageId.HonamiStoryLifeSupportUpResponse)]
	public sealed class HonamiStoryLifeSupportUpResponse : IMessage<HonamiStoryLifeSupportUpResponse>, IMessage, IEquatable<HonamiStoryLifeSupportUpResponse>, IDeepCloneable<HonamiStoryLifeSupportUpResponse>, IBufferMessage
	{
		// Token: 0x0600ACA7 RID: 44199 RVA: 0x0019F899 File Offset: 0x0019DA99
		[NullableContext(1)]
		public static HonamiStoryLifeSupportUpResponse Create()
		{
			return new HonamiStoryLifeSupportUpResponse();
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x0019F8A0 File Offset: 0x0019DAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x0019F8A3 File Offset: 0x0019DAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLifeSupportUpResponse.Descriptor;
			}
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x0019F8AA File Offset: 0x0019DAAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse()
		{
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x0019F8B2 File Offset: 0x0019DAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse(HonamiStoryLifeSupportUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activityId_ = other.activityId_;
			this.lifeSupportLevel_ = other.lifeSupportLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x0019F8EF File Offset: 0x0019DAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLifeSupportUpResponse Clone()
		{
			return new HonamiStoryLifeSupportUpResponse(this);
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x0019F8F7 File Offset: 0x0019DAF7
		// (set) Token: 0x0600ACAE RID: 44206 RVA: 0x0019F8FF File Offset: 0x0019DAFF
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

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600ACAF RID: 44207 RVA: 0x0019F908 File Offset: 0x0019DB08
		// (set) Token: 0x0600ACB0 RID: 44208 RVA: 0x0019F910 File Offset: 0x0019DB10
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

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600ACB1 RID: 44209 RVA: 0x0019F919 File Offset: 0x0019DB19
		// (set) Token: 0x0600ACB2 RID: 44210 RVA: 0x0019F921 File Offset: 0x0019DB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LifeSupportLevel
		{
			get
			{
				return this.lifeSupportLevel_;
			}
			set
			{
				this.lifeSupportLevel_ = value;
			}
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x0019F92A File Offset: 0x0019DB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLifeSupportUpResponse);
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x0019F938 File Offset: 0x0019DB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLifeSupportUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActivityId == other.ActivityId && this.LifeSupportLevel == other.LifeSupportLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x0019F994 File Offset: 0x0019DB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LifeSupportLevel != 0)
			{
				num ^= this.LifeSupportLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x0019FA0B File Offset: 0x0019DC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x0019FA18 File Offset: 0x0019DC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x0019FA24 File Offset: 0x0019DC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LifeSupportLevel != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LifeSupportLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x0019FA9C File Offset: 0x0019DC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LifeSupportLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LifeSupportLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x0019FB0C File Offset: 0x0019DD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLifeSupportUpResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LifeSupportLevel != 0)
			{
				this.LifeSupportLevel = other.LifeSupportLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x0019FB70 File Offset: 0x0019DD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x0019FB7C File Offset: 0x0019DD7C
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
				if (num != 88U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LifeSupportLevel = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E95 RID: 20117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E96 RID: 20118
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004E97 RID: 20119
		private ErrorCode errorCode_;

		// Token: 0x04004E98 RID: 20120
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04004E99 RID: 20121
		private int activityId_;

		// Token: 0x04004E9A RID: 20122
		public const int LifeSupportLevelFieldNumber = 14;

		// Token: 0x04004E9B RID: 20123
		private int lifeSupportLevel_;
	}
}
