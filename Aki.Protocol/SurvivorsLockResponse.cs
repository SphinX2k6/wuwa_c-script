using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012CF RID: 4815
	[NetMessage(EMessageId.SurvivorsLockResponse)]
	public sealed class SurvivorsLockResponse : IMessage<SurvivorsLockResponse>, IMessage, IEquatable<SurvivorsLockResponse>, IDeepCloneable<SurvivorsLockResponse>, IBufferMessage
	{
		// Token: 0x060199E7 RID: 104935 RVA: 0x003B983F File Offset: 0x003B7A3F
		[NullableContext(1)]
		public static SurvivorsLockResponse Create()
		{
			return new SurvivorsLockResponse();
		}

		// Token: 0x1700566F RID: 22127
		// (get) Token: 0x060199E8 RID: 104936 RVA: 0x003B9846 File Offset: 0x003B7A46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005670 RID: 22128
		// (get) Token: 0x060199E9 RID: 104937 RVA: 0x003B9849 File Offset: 0x003B7A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsLockResponse.Descriptor;
			}
		}

		// Token: 0x060199EA RID: 104938 RVA: 0x003B9850 File Offset: 0x003B7A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse()
		{
		}

		// Token: 0x060199EB RID: 104939 RVA: 0x003B9858 File Offset: 0x003B7A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse(SurvivorsLockResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060199EC RID: 104940 RVA: 0x003B987D File Offset: 0x003B7A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsLockResponse Clone()
		{
			return new SurvivorsLockResponse(this);
		}

		// Token: 0x17005671 RID: 22129
		// (get) Token: 0x060199ED RID: 104941 RVA: 0x003B9885 File Offset: 0x003B7A85
		// (set) Token: 0x060199EE RID: 104942 RVA: 0x003B988D File Offset: 0x003B7A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x060199EF RID: 104943 RVA: 0x003B9896 File Offset: 0x003B7A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsLockResponse);
		}

		// Token: 0x060199F0 RID: 104944 RVA: 0x003B98A4 File Offset: 0x003B7AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsLockResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060199F1 RID: 104945 RVA: 0x003B98D4 File Offset: 0x003B7AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x003B9919 File Offset: 0x003B7B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060199F3 RID: 104947 RVA: 0x003B9926 File Offset: 0x003B7B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060199F4 RID: 104948 RVA: 0x003B992F File Offset: 0x003B7B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060199F5 RID: 104949 RVA: 0x003B9960 File Offset: 0x003B7B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060199F6 RID: 104950 RVA: 0x003B999E File Offset: 0x003B7B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsLockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060199F7 RID: 104951 RVA: 0x003B99CF File Offset: 0x003B7BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060199F8 RID: 104952 RVA: 0x003B99D8 File Offset: 0x003B7BD8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009645 RID: 38469
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009646 RID: 38470
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04009647 RID: 38471
		private ErrorCode errCode_;
	}
}
