using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001529 RID: 5417
	[NetMessage(EMessageId.WuWuTaskRewardResponse)]
	public sealed class WuWuTaskRewardResponse : IMessage<WuWuTaskRewardResponse>, IMessage, IEquatable<WuWuTaskRewardResponse>, IDeepCloneable<WuWuTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0601CA07 RID: 117255 RVA: 0x00422439 File Offset: 0x00420639
		[NullableContext(1)]
		public static WuWuTaskRewardResponse Create()
		{
			return new WuWuTaskRewardResponse();
		}

		// Token: 0x17006084 RID: 24708
		// (get) Token: 0x0601CA08 RID: 117256 RVA: 0x00422440 File Offset: 0x00420640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006085 RID: 24709
		// (get) Token: 0x0601CA09 RID: 117257 RVA: 0x00422443 File Offset: 0x00420643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601CA0A RID: 117258 RVA: 0x0042244A File Offset: 0x0042064A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse()
		{
		}

		// Token: 0x0601CA0B RID: 117259 RVA: 0x00422452 File Offset: 0x00420652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse(WuWuTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA0C RID: 117260 RVA: 0x00422477 File Offset: 0x00420677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskRewardResponse Clone()
		{
			return new WuWuTaskRewardResponse(this);
		}

		// Token: 0x17006086 RID: 24710
		// (get) Token: 0x0601CA0D RID: 117261 RVA: 0x0042247F File Offset: 0x0042067F
		// (set) Token: 0x0601CA0E RID: 117262 RVA: 0x00422487 File Offset: 0x00420687
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

		// Token: 0x0601CA0F RID: 117263 RVA: 0x00422490 File Offset: 0x00420690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskRewardResponse);
		}

		// Token: 0x0601CA10 RID: 117264 RVA: 0x0042249E File Offset: 0x0042069E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA11 RID: 117265 RVA: 0x004224CC File Offset: 0x004206CC
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

		// Token: 0x0601CA12 RID: 117266 RVA: 0x00422511 File Offset: 0x00420711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA13 RID: 117267 RVA: 0x0042251E File Offset: 0x0042071E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA14 RID: 117268 RVA: 0x00422527 File Offset: 0x00420727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA15 RID: 117269 RVA: 0x0042255C File Offset: 0x0042075C
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

		// Token: 0x0601CA16 RID: 117270 RVA: 0x0042259A File Offset: 0x0042079A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskRewardResponse other)
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

		// Token: 0x0601CA17 RID: 117271 RVA: 0x004225CB File Offset: 0x004207CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA18 RID: 117272 RVA: 0x004225D4 File Offset: 0x004207D4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A3B1 RID: 41905
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3B2 RID: 41906
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A3B3 RID: 41907
		private ErrorCode errorCode_;
	}
}
