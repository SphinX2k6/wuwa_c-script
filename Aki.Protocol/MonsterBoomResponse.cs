using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F5 RID: 2549
	[NetMessage(EMessageId.MonsterBoomResponse)]
	public sealed class MonsterBoomResponse : IMessage<MonsterBoomResponse>, IMessage, IEquatable<MonsterBoomResponse>, IDeepCloneable<MonsterBoomResponse>, IBufferMessage
	{
		// Token: 0x0600DF34 RID: 57140 RVA: 0x0020B97C File Offset: 0x00209B7C
		[NullableContext(1)]
		public static MonsterBoomResponse Create()
		{
			return new MonsterBoomResponse();
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x0020B983 File Offset: 0x00209B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x0020B986 File Offset: 0x00209B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterBoomResponse.Descriptor;
			}
		}

		// Token: 0x0600DF37 RID: 57143 RVA: 0x0020B98D File Offset: 0x00209B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse()
		{
		}

		// Token: 0x0600DF38 RID: 57144 RVA: 0x0020B995 File Offset: 0x00209B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse(MonsterBoomResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x0020B9BA File Offset: 0x00209BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterBoomResponse Clone()
		{
			return new MonsterBoomResponse(this);
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600DF3A RID: 57146 RVA: 0x0020B9C2 File Offset: 0x00209BC2
		// (set) Token: 0x0600DF3B RID: 57147 RVA: 0x0020B9CA File Offset: 0x00209BCA
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

		// Token: 0x0600DF3C RID: 57148 RVA: 0x0020B9D3 File Offset: 0x00209BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterBoomResponse);
		}

		// Token: 0x0600DF3D RID: 57149 RVA: 0x0020B9E1 File Offset: 0x00209BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterBoomResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF3E RID: 57150 RVA: 0x0020BA10 File Offset: 0x00209C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600DF3F RID: 57151 RVA: 0x0020BA55 File Offset: 0x00209C55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF40 RID: 57152 RVA: 0x0020BA62 File Offset: 0x00209C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x0020BA6B File Offset: 0x00209C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF42 RID: 57154 RVA: 0x0020BAA0 File Offset: 0x00209CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600DF43 RID: 57155 RVA: 0x0020BADE File Offset: 0x00209CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterBoomResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF44 RID: 57156 RVA: 0x0020BB0F File Offset: 0x00209D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x0020BB18 File Offset: 0x00209D18
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005C0B RID: 23563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C0C RID: 23564
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005C0D RID: 23565
		private ErrorCode errorCode_;
	}
}
