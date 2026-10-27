using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D1 RID: 1233
	public sealed class EntrustInfo : IMessage<EntrustInfo>, IMessage, IEquatable<EntrustInfo>, IDeepCloneable<EntrustInfo>, IBufferMessage
	{
		// Token: 0x0600751C RID: 29980 RVA: 0x0011ED2F File Offset: 0x0011CF2F
		[NullableContext(1)]
		public static EntrustInfo Create()
		{
			return new EntrustInfo();
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x0011ED36 File Offset: 0x0011CF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntrustInfo> Parser
		{
			get
			{
				return EntrustInfo._parser;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x0011ED3D File Offset: 0x0011CF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x0011ED40 File Offset: 0x0011CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntrustInfo.Descriptor;
			}
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x0011ED47 File Offset: 0x0011CF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo()
		{
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x0011ED4F File Offset: 0x0011CF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo(EntrustInfo other) : this()
		{
			this.entrustId_ = other.entrustId_;
			this.isVisiable_ = other.isVisiable_;
			this.historyLevel_ = other.historyLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x0011ED8C File Offset: 0x0011CF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo Clone()
		{
			return new EntrustInfo(this);
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x0011ED94 File Offset: 0x0011CF94
		// (set) Token: 0x06007524 RID: 29988 RVA: 0x0011ED9C File Offset: 0x0011CF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x0011EDA5 File Offset: 0x0011CFA5
		// (set) Token: 0x06007526 RID: 29990 RVA: 0x0011EDAD File Offset: 0x0011CFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisiable
		{
			get
			{
				return this.isVisiable_;
			}
			set
			{
				this.isVisiable_ = value;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0011EDB6 File Offset: 0x0011CFB6
		// (set) Token: 0x06007528 RID: 29992 RVA: 0x0011EDBE File Offset: 0x0011CFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HistoryLevel
		{
			get
			{
				return this.historyLevel_;
			}
			set
			{
				this.historyLevel_ = value;
			}
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x0011EDC7 File Offset: 0x0011CFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntrustInfo);
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x0011EDD8 File Offset: 0x0011CFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntrustInfo other)
		{
			return other != null && (other == this || (this.EntrustId == other.EntrustId && this.IsVisiable == other.IsVisiable && this.HistoryLevel == other.HistoryLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x0011EE34 File Offset: 0x0011D034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this.IsVisiable)
			{
				num ^= this.IsVisiable.GetHashCode();
			}
			if (this.HistoryLevel != 0)
			{
				num ^= this.HistoryLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x0011EEA5 File Offset: 0x0011D0A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x0011EEB2 File Offset: 0x0011D0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x0011EEBC File Offset: 0x0011D0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntrustId);
			}
			if (this.IsVisiable)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsVisiable);
			}
			if (this.HistoryLevel != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HistoryLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x0011EF30 File Offset: 0x0011D130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this.IsVisiable)
			{
				num += 2;
			}
			if (this.HistoryLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HistoryLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x0011EF94 File Offset: 0x0011D194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntrustInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			if (other.IsVisiable)
			{
				this.IsVisiable = other.IsVisiable;
			}
			if (other.HistoryLevel != 0)
			{
				this.HistoryLevel = other.HistoryLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0011EFF8 File Offset: 0x0011D1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0011F004 File Offset: 0x0011D204
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HistoryLevel = input.ReadInt32();
						}
					}
					else
					{
						this.IsVisiable = input.ReadBool();
					}
				}
				else
				{
					this.EntrustId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D9A RID: 15770
		private static readonly MessageParser<EntrustInfo> _parser = new MessageParser<EntrustInfo>(() => new EntrustInfo());

		// Token: 0x04003D9B RID: 15771
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D9C RID: 15772
		public const int EntrustIdFieldNumber = 1;

		// Token: 0x04003D9D RID: 15773
		private int entrustId_;

		// Token: 0x04003D9E RID: 15774
		public const int IsVisiableFieldNumber = 2;

		// Token: 0x04003D9F RID: 15775
		private bool isVisiable_;

		// Token: 0x04003DA0 RID: 15776
		public const int HistoryLevelFieldNumber = 3;

		// Token: 0x04003DA1 RID: 15777
		private int historyLevel_;
	}
}
