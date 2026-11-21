using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001121 RID: 4385
	[NetMessage(EMessageId.RollBlockSwitchControlBlockResponse)]
	public sealed class RollBlockSwitchControlBlockResponse : IMessage<RollBlockSwitchControlBlockResponse>, IMessage, IEquatable<RollBlockSwitchControlBlockResponse>, IDeepCloneable<RollBlockSwitchControlBlockResponse>, IBufferMessage
	{
		// Token: 0x060176DC RID: 95964 RVA: 0x003686DD File Offset: 0x003668DD
		[NullableContext(1)]
		public static RollBlockSwitchControlBlockResponse Create()
		{
			return new RollBlockSwitchControlBlockResponse();
		}

		// Token: 0x17004EB6 RID: 20150
		// (get) Token: 0x060176DD RID: 95965 RVA: 0x003686E4 File Offset: 0x003668E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EB7 RID: 20151
		// (get) Token: 0x060176DE RID: 95966 RVA: 0x003686E7 File Offset: 0x003668E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSwitchControlBlockResponse.Descriptor;
			}
		}

		// Token: 0x060176DF RID: 95967 RVA: 0x003686EE File Offset: 0x003668EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse()
		{
		}

		// Token: 0x060176E0 RID: 95968 RVA: 0x003686F6 File Offset: 0x003668F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse(RollBlockSwitchControlBlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.preMainControlBlockEntityId_ = other.preMainControlBlockEntityId_;
			this.curMainControlBlockEntityId_ = other.curMainControlBlockEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176E1 RID: 95969 RVA: 0x00368733 File Offset: 0x00366933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse Clone()
		{
			return new RollBlockSwitchControlBlockResponse(this);
		}

		// Token: 0x17004EB8 RID: 20152
		// (get) Token: 0x060176E2 RID: 95970 RVA: 0x0036873B File Offset: 0x0036693B
		// (set) Token: 0x060176E3 RID: 95971 RVA: 0x00368743 File Offset: 0x00366943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17004EB9 RID: 20153
		// (get) Token: 0x060176E4 RID: 95972 RVA: 0x0036874C File Offset: 0x0036694C
		// (set) Token: 0x060176E5 RID: 95973 RVA: 0x00368754 File Offset: 0x00366954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreMainControlBlockEntityId
		{
			get
			{
				return this.preMainControlBlockEntityId_;
			}
			set
			{
				this.preMainControlBlockEntityId_ = value;
			}
		}

		// Token: 0x17004EBA RID: 20154
		// (get) Token: 0x060176E6 RID: 95974 RVA: 0x0036875D File Offset: 0x0036695D
		// (set) Token: 0x060176E7 RID: 95975 RVA: 0x00368765 File Offset: 0x00366965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurMainControlBlockEntityId
		{
			get
			{
				return this.curMainControlBlockEntityId_;
			}
			set
			{
				this.curMainControlBlockEntityId_ = value;
			}
		}

		// Token: 0x060176E8 RID: 95976 RVA: 0x0036876E File Offset: 0x0036696E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSwitchControlBlockResponse);
		}

		// Token: 0x060176E9 RID: 95977 RVA: 0x0036877C File Offset: 0x0036697C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSwitchControlBlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.PreMainControlBlockEntityId == other.PreMainControlBlockEntityId && this.CurMainControlBlockEntityId == other.CurMainControlBlockEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176EA RID: 95978 RVA: 0x003687D8 File Offset: 0x003669D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				num ^= this.PreMainControlBlockEntityId.GetHashCode();
			}
			if (this.CurMainControlBlockEntityId != 0L)
			{
				num ^= this.CurMainControlBlockEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176EB RID: 95979 RVA: 0x0036884F File Offset: 0x00366A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176EC RID: 95980 RVA: 0x0036885C File Offset: 0x00366A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176ED RID: 95981 RVA: 0x00368868 File Offset: 0x00366A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurMainControlBlockEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.CurMainControlBlockEntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Code);
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.PreMainControlBlockEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176EE RID: 95982 RVA: 0x003688E0 File Offset: 0x00366AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreMainControlBlockEntityId);
			}
			if (this.CurMainControlBlockEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurMainControlBlockEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176EF RID: 95983 RVA: 0x00368950 File Offset: 0x00366B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSwitchControlBlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.PreMainControlBlockEntityId != 0L)
			{
				this.PreMainControlBlockEntityId = other.PreMainControlBlockEntityId;
			}
			if (other.CurMainControlBlockEntityId != 0L)
			{
				this.CurMainControlBlockEntityId = other.CurMainControlBlockEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176F0 RID: 95984 RVA: 0x003689B4 File Offset: 0x00366BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176F1 RID: 95985 RVA: 0x003689C0 File Offset: 0x00366BC0
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
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PreMainControlBlockEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CurMainControlBlockEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008BD6 RID: 35798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BD7 RID: 35799
		public const int CodeFieldNumber = 13;

		// Token: 0x04008BD8 RID: 35800
		private ErrorCode code_;

		// Token: 0x04008BD9 RID: 35801
		public const int PreMainControlBlockEntityIdFieldNumber = 14;

		// Token: 0x04008BDA RID: 35802
		private long preMainControlBlockEntityId_;

		// Token: 0x04008BDB RID: 35803
		public const int CurMainControlBlockEntityIdFieldNumber = 12;

		// Token: 0x04008BDC RID: 35804
		private long curMainControlBlockEntityId_;
	}
}
