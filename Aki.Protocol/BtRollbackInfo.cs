using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F1 RID: 497
	public sealed class BtRollbackInfo : IMessage<BtRollbackInfo>, IMessage, IEquatable<BtRollbackInfo>, IDeepCloneable<BtRollbackInfo>, IBufferMessage
	{
		// Token: 0x060037A8 RID: 14248 RVA: 0x0008B559 File Offset: 0x00089759
		[NullableContext(1)]
		public static BtRollbackInfo Create()
		{
			return new BtRollbackInfo();
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x0008B560 File Offset: 0x00089760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x0008B563 File Offset: 0x00089763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackInfo.Descriptor;
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0008B56A File Offset: 0x0008976A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfo()
		{
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x0008B574 File Offset: 0x00089774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfo(BtRollbackInfo other) : this()
		{
			BtRollbackInfo.InfoOneofCase infoCase = other.InfoCase;
			if (infoCase != BtRollbackInfo.InfoOneofCase.FailRollbackData)
			{
				if (infoCase == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
				{
					this.ForceClosedRollbackData = other.ForceClosedRollbackData.Clone();
				}
			}
			else
			{
				this.FailRollbackData = other.FailRollbackData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0008B5CD File Offset: 0x000897CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfo Clone()
		{
			return new BtRollbackInfo(this);
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x0008B5D5 File Offset: 0x000897D5
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x0008B5ED File Offset: 0x000897ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailRollbackData FailRollbackData
		{
			get
			{
				if (this.infoCase_ != BtRollbackInfo.InfoOneofCase.FailRollbackData)
				{
					return null;
				}
				return (FailRollbackData)this.info_;
			}
			set
			{
				this.info_ = value;
				this.infoCase_ = ((value == null) ? BtRollbackInfo.InfoOneofCase.None : BtRollbackInfo.InfoOneofCase.FailRollbackData);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x0008B603 File Offset: 0x00089803
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x0008B61B File Offset: 0x0008981B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForceClosedRollbackData ForceClosedRollbackData
		{
			get
			{
				if (this.infoCase_ != BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
				{
					return null;
				}
				return (ForceClosedRollbackData)this.info_;
			}
			set
			{
				this.info_ = value;
				this.infoCase_ = ((value == null) ? BtRollbackInfo.InfoOneofCase.None : BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x0008B631 File Offset: 0x00089831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfo.InfoOneofCase InfoCase
		{
			get
			{
				return this.infoCase_;
			}
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0008B639 File Offset: 0x00089839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInfo()
		{
			this.infoCase_ = BtRollbackInfo.InfoOneofCase.None;
			this.info_ = null;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0008B649 File Offset: 0x00089849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackInfo);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0008B658 File Offset: 0x00089858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackInfo other)
		{
			return other != null && (other == this || (object.Equals(this.FailRollbackData, other.FailRollbackData) && object.Equals(this.ForceClosedRollbackData, other.ForceClosedRollbackData) && this.InfoCase == other.InfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x0008B6BC File Offset: 0x000898BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.FailRollbackData)
			{
				num ^= this.FailRollbackData.GetHashCode();
			}
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
			{
				num ^= this.ForceClosedRollbackData.GetHashCode();
			}
			num ^= (int)this.infoCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0008B719 File Offset: 0x00089919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0008B726 File Offset: 0x00089926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x0008B730 File Offset: 0x00089930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.FailRollbackData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FailRollbackData);
			}
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ForceClosedRollbackData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0008B78C File Offset: 0x0008998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.FailRollbackData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FailRollbackData);
			}
			if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ForceClosedRollbackData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0008B7E4 File Offset: 0x000899E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackInfo other)
		{
			if (other == null)
			{
				return;
			}
			BtRollbackInfo.InfoOneofCase infoCase = other.InfoCase;
			if (infoCase != BtRollbackInfo.InfoOneofCase.FailRollbackData)
			{
				if (infoCase == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
				{
					if (this.ForceClosedRollbackData == null)
					{
						this.ForceClosedRollbackData = new ForceClosedRollbackData();
					}
					this.ForceClosedRollbackData.MergeFrom(other.ForceClosedRollbackData);
				}
			}
			else
			{
				if (this.FailRollbackData == null)
				{
					this.FailRollbackData = new FailRollbackData();
				}
				this.FailRollbackData.MergeFrom(other.FailRollbackData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0008B867 File Offset: 0x00089A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x0008B870 File Offset: 0x00089A70
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ForceClosedRollbackData forceClosedRollbackData = new ForceClosedRollbackData();
						if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.ForceClosedRollbackData)
						{
							forceClosedRollbackData.MergeFrom(this.ForceClosedRollbackData);
						}
						input.ReadMessage(forceClosedRollbackData);
						this.ForceClosedRollbackData = forceClosedRollbackData;
					}
				}
				else
				{
					FailRollbackData failRollbackData = new FailRollbackData();
					if (this.infoCase_ == BtRollbackInfo.InfoOneofCase.FailRollbackData)
					{
						failRollbackData.MergeFrom(this.FailRollbackData);
					}
					input.ReadMessage(failRollbackData);
					this.FailRollbackData = failRollbackData;
				}
			}
		}

		// Token: 0x04002B43 RID: 11075
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B44 RID: 11076
		public const int FailRollbackDataFieldNumber = 1;

		// Token: 0x04002B45 RID: 11077
		public const int ForceClosedRollbackDataFieldNumber = 2;

		// Token: 0x04002B46 RID: 11078
		private object info_;

		// Token: 0x04002B47 RID: 11079
		private BtRollbackInfo.InfoOneofCase infoCase_;

		// Token: 0x0200177F RID: 6015
		public enum InfoOneofCase
		{
			// Token: 0x0400CA84 RID: 51844
			None,
			// Token: 0x0400CA85 RID: 51845
			FailRollbackData,
			// Token: 0x0400CA86 RID: 51846
			ForceClosedRollbackData
		}
	}
}
