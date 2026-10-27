using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B6 RID: 694
	public sealed class CombinePartInfo : IMessage<CombinePartInfo>, IMessage, IEquatable<CombinePartInfo>, IDeepCloneable<CombinePartInfo>, IBufferMessage
	{
		// Token: 0x060047B6 RID: 18358 RVA: 0x000B010C File Offset: 0x000AE30C
		[NullableContext(1)]
		public static CombinePartInfo Create()
		{
			return new CombinePartInfo();
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x000B0113 File Offset: 0x000AE313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinePartInfo> Parser
		{
			get
			{
				return CombinePartInfo._parser;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x000B011A File Offset: 0x000AE31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x000B011D File Offset: 0x000AE31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinePartInfo.Descriptor;
			}
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x000B0124 File Offset: 0x000AE324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo()
		{
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x000B012C File Offset: 0x000AE32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo(CombinePartInfo other) : this()
		{
			this.combinerEntityId_ = other.combinerEntityId_;
			this.offsetPos_ = ((other.offsetPos_ != null) ? other.offsetPos_.Clone() : null);
			this.offsetRotate_ = ((other.offsetRotate_ != null) ? other.offsetRotate_.Clone() : null);
			this.partId_ = other.partId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x000B01A0 File Offset: 0x000AE3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinePartInfo Clone()
		{
			return new CombinePartInfo(this);
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x000B01A8 File Offset: 0x000AE3A8
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x000B01B0 File Offset: 0x000AE3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CombinerEntityId
		{
			get
			{
				return this.combinerEntityId_;
			}
			set
			{
				this.combinerEntityId_ = value;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x000B01B9 File Offset: 0x000AE3B9
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x000B01C1 File Offset: 0x000AE3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector OffsetPos
		{
			get
			{
				return this.offsetPos_;
			}
			set
			{
				this.offsetPos_ = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x000B01CA File Offset: 0x000AE3CA
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x000B01D2 File Offset: 0x000AE3D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator OffsetRotate
		{
			get
			{
				return this.offsetRotate_;
			}
			set
			{
				this.offsetRotate_ = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x000B01DB File Offset: 0x000AE3DB
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x000B01E3 File Offset: 0x000AE3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x000B01EC File Offset: 0x000AE3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinePartInfo);
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x000B01FC File Offset: 0x000AE3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinePartInfo other)
		{
			return other != null && (other == this || (this.CombinerEntityId == other.CombinerEntityId && object.Equals(this.OffsetPos, other.OffsetPos) && object.Equals(this.OffsetRotate, other.OffsetRotate) && this.PartId == other.PartId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x000B0270 File Offset: 0x000AE470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CombinerEntityId != 0L)
			{
				num ^= this.CombinerEntityId.GetHashCode();
			}
			if (this.offsetPos_ != null)
			{
				num ^= this.OffsetPos.GetHashCode();
			}
			if (this.offsetRotate_ != null)
			{
				num ^= this.OffsetRotate.GetHashCode();
			}
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x000B02F4 File Offset: 0x000AE4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x000B0301 File Offset: 0x000AE501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x000B030C File Offset: 0x000AE50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CombinerEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.CombinerEntityId);
			}
			if (this.offsetPos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.OffsetPos);
			}
			if (this.offsetRotate_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.OffsetRotate);
			}
			if (this.PartId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PartId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x000B039C File Offset: 0x000AE59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CombinerEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CombinerEntityId);
			}
			if (this.offsetPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OffsetPos);
			}
			if (this.offsetRotate_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OffsetRotate);
			}
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x000B0424 File Offset: 0x000AE624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombinePartInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CombinerEntityId != 0L)
			{
				this.CombinerEntityId = other.CombinerEntityId;
			}
			if (other.offsetPos_ != null)
			{
				if (this.offsetPos_ == null)
				{
					this.OffsetPos = new Vector();
				}
				this.OffsetPos.MergeFrom(other.OffsetPos);
			}
			if (other.offsetRotate_ != null)
			{
				if (this.offsetRotate_ == null)
				{
					this.OffsetRotate = new Rotator();
				}
				this.OffsetRotate.MergeFrom(other.OffsetRotate);
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x000B04CC File Offset: 0x000AE6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x000B04D8 File Offset: 0x000AE6D8
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
						this.CombinerEntityId = input.ReadInt64();
						continue;
					}
					if (num == 18U)
					{
						if (this.offsetPos_ == null)
						{
							this.OffsetPos = new Vector();
						}
						input.ReadMessage(this.OffsetPos);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.offsetRotate_ == null)
						{
							this.OffsetRotate = new Rotator();
						}
						input.ReadMessage(this.OffsetRotate);
						continue;
					}
					if (num == 32U)
					{
						this.PartId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FB4 RID: 12212
		private static readonly MessageParser<CombinePartInfo> _parser = new MessageParser<CombinePartInfo>(() => new CombinePartInfo());

		// Token: 0x04002FB5 RID: 12213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FB6 RID: 12214
		public const int CombinerEntityIdFieldNumber = 1;

		// Token: 0x04002FB7 RID: 12215
		private long combinerEntityId_;

		// Token: 0x04002FB8 RID: 12216
		public const int OffsetPosFieldNumber = 2;

		// Token: 0x04002FB9 RID: 12217
		private Vector offsetPos_;

		// Token: 0x04002FBA RID: 12218
		public const int OffsetRotateFieldNumber = 3;

		// Token: 0x04002FBB RID: 12219
		private Rotator offsetRotate_;

		// Token: 0x04002FBC RID: 12220
		public const int PartIdFieldNumber = 4;

		// Token: 0x04002FBD RID: 12221
		private int partId_;
	}
}
