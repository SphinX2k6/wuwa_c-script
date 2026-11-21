using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000778 RID: 1912
	[NetMessage(EMessageId.HonamiStoryLockItemResponse)]
	public sealed class HonamiStoryLockItemResponse : IMessage<HonamiStoryLockItemResponse>, IMessage, IEquatable<HonamiStoryLockItemResponse>, IDeepCloneable<HonamiStoryLockItemResponse>, IBufferMessage
	{
		// Token: 0x0600AD1F RID: 44319 RVA: 0x001A081F File Offset: 0x0019EA1F
		[NullableContext(1)]
		public static HonamiStoryLockItemResponse Create()
		{
			return new HonamiStoryLockItemResponse();
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600AD20 RID: 44320 RVA: 0x001A0826 File Offset: 0x0019EA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600AD21 RID: 44321 RVA: 0x001A0829 File Offset: 0x0019EA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLockItemResponse.Descriptor;
			}
		}

		// Token: 0x0600AD22 RID: 44322 RVA: 0x001A0830 File Offset: 0x0019EA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse()
		{
		}

		// Token: 0x0600AD23 RID: 44323 RVA: 0x001A0838 File Offset: 0x0019EA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse(HonamiStoryLockItemResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.backPackId_ = other.backPackId_;
			this.itemUid_ = other.itemUid_;
			this.isLock_ = other.isLock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD24 RID: 44324 RVA: 0x001A088C File Offset: 0x0019EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLockItemResponse Clone()
		{
			return new HonamiStoryLockItemResponse(this);
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600AD25 RID: 44325 RVA: 0x001A0894 File Offset: 0x0019EA94
		// (set) Token: 0x0600AD26 RID: 44326 RVA: 0x001A089C File Offset: 0x0019EA9C
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

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x001A08A5 File Offset: 0x0019EAA5
		// (set) Token: 0x0600AD28 RID: 44328 RVA: 0x001A08AD File Offset: 0x0019EAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackPackId
		{
			get
			{
				return this.backPackId_;
			}
			set
			{
				this.backPackId_ = value;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x001A08B6 File Offset: 0x0019EAB6
		// (set) Token: 0x0600AD2A RID: 44330 RVA: 0x001A08BE File Offset: 0x0019EABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUid
		{
			get
			{
				return this.itemUid_;
			}
			set
			{
				this.itemUid_ = value;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600AD2B RID: 44331 RVA: 0x001A08C7 File Offset: 0x0019EAC7
		// (set) Token: 0x0600AD2C RID: 44332 RVA: 0x001A08CF File Offset: 0x0019EACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLock
		{
			get
			{
				return this.isLock_;
			}
			set
			{
				this.isLock_ = value;
			}
		}

		// Token: 0x0600AD2D RID: 44333 RVA: 0x001A08D8 File Offset: 0x0019EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLockItemResponse);
		}

		// Token: 0x0600AD2E RID: 44334 RVA: 0x001A08E8 File Offset: 0x0019EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLockItemResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.BackPackId == other.BackPackId && this.ItemUid == other.ItemUid && this.IsLock == other.IsLock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD2F RID: 44335 RVA: 0x001A0954 File Offset: 0x0019EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.BackPackId != 0)
			{
				num ^= this.BackPackId.GetHashCode();
			}
			if (this.ItemUid != 0)
			{
				num ^= this.ItemUid.GetHashCode();
			}
			if (this.IsLock)
			{
				num ^= this.IsLock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD30 RID: 44336 RVA: 0x001A09E4 File Offset: 0x0019EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD31 RID: 44337 RVA: 0x001A09F1 File Offset: 0x0019EBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD32 RID: 44338 RVA: 0x001A09FC File Offset: 0x0019EBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemUid);
			}
			if (this.IsLock)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsLock);
			}
			if (this.BackPackId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BackPackId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD33 RID: 44339 RVA: 0x001A0A8C File Offset: 0x0019EC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.BackPackId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BackPackId);
			}
			if (this.ItemUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUid);
			}
			if (this.IsLock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD34 RID: 44340 RVA: 0x001A0B08 File Offset: 0x0019ED08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLockItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.BackPackId != 0)
			{
				this.BackPackId = other.BackPackId;
			}
			if (other.ItemUid != 0)
			{
				this.ItemUid = other.ItemUid;
			}
			if (other.IsLock)
			{
				this.IsLock = other.IsLock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD35 RID: 44341 RVA: 0x001A0B80 File Offset: 0x0019ED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD36 RID: 44342 RVA: 0x001A0B8C File Offset: 0x0019ED8C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.ItemUid = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsLock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BackPackId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004EB5 RID: 20149
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EB6 RID: 20150
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004EB7 RID: 20151
		private ErrorCode errorCode_;

		// Token: 0x04004EB8 RID: 20152
		public const int BackPackIdFieldNumber = 7;

		// Token: 0x04004EB9 RID: 20153
		private int backPackId_;

		// Token: 0x04004EBA RID: 20154
		public const int ItemUidFieldNumber = 1;

		// Token: 0x04004EBB RID: 20155
		private int itemUid_;

		// Token: 0x04004EBC RID: 20156
		public const int IsLockFieldNumber = 3;

		// Token: 0x04004EBD RID: 20157
		private bool isLock_;
	}
}
