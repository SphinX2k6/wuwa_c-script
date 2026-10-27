using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE6 RID: 3302
	[NetMessage(EMessageId.PhantomMusicCollectUpdateResponse)]
	public sealed class PhantomMusicCollectUpdateResponse : IMessage<PhantomMusicCollectUpdateResponse>, IMessage, IEquatable<PhantomMusicCollectUpdateResponse>, IDeepCloneable<PhantomMusicCollectUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011DD7 RID: 73175 RVA: 0x0029D2A9 File Offset: 0x0029B4A9
		[NullableContext(1)]
		public static PhantomMusicCollectUpdateResponse Create()
		{
			return new PhantomMusicCollectUpdateResponse();
		}

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x06011DD8 RID: 73176 RVA: 0x0029D2B0 File Offset: 0x0029B4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x06011DD9 RID: 73177 RVA: 0x0029D2B3 File Offset: 0x0029B4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomMusicCollectUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011DDA RID: 73178 RVA: 0x0029D2BA File Offset: 0x0029B4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse()
		{
		}

		// Token: 0x06011DDB RID: 73179 RVA: 0x0029D2C2 File Offset: 0x0029B4C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse(PhantomMusicCollectUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011DDC RID: 73180 RVA: 0x0029D2E7 File Offset: 0x0029B4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomMusicCollectUpdateResponse Clone()
		{
			return new PhantomMusicCollectUpdateResponse(this);
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x06011DDD RID: 73181 RVA: 0x0029D2EF File Offset: 0x0029B4EF
		// (set) Token: 0x06011DDE RID: 73182 RVA: 0x0029D2F7 File Offset: 0x0029B4F7
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

		// Token: 0x06011DDF RID: 73183 RVA: 0x0029D300 File Offset: 0x0029B500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomMusicCollectUpdateResponse);
		}

		// Token: 0x06011DE0 RID: 73184 RVA: 0x0029D30E File Offset: 0x0029B50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomMusicCollectUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011DE1 RID: 73185 RVA: 0x0029D33C File Offset: 0x0029B53C
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

		// Token: 0x06011DE2 RID: 73186 RVA: 0x0029D381 File Offset: 0x0029B581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011DE3 RID: 73187 RVA: 0x0029D38E File Offset: 0x0029B58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011DE4 RID: 73188 RVA: 0x0029D397 File Offset: 0x0029B597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011DE5 RID: 73189 RVA: 0x0029D3CC File Offset: 0x0029B5CC
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

		// Token: 0x06011DE6 RID: 73190 RVA: 0x0029D40A File Offset: 0x0029B60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomMusicCollectUpdateResponse other)
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

		// Token: 0x06011DE7 RID: 73191 RVA: 0x0029D43B File Offset: 0x0029B63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011DE8 RID: 73192 RVA: 0x0029D444 File Offset: 0x0029B644
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400702A RID: 28714
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400702B RID: 28715
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400702C RID: 28716
		private ErrorCode errorCode_;
	}
}
