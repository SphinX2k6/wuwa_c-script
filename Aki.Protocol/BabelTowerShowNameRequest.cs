using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000153 RID: 339
	[NetMessage(EMessageId.BabelTowerShowNameRequest)]
	public sealed class BabelTowerShowNameRequest : IMessage<BabelTowerShowNameRequest>, IMessage, IEquatable<BabelTowerShowNameRequest>, IDeepCloneable<BabelTowerShowNameRequest>, IBufferMessage
	{
		// Token: 0x06002B07 RID: 11015 RVA: 0x000706D9 File Offset: 0x0006E8D9
		[NullableContext(1)]
		public static BabelTowerShowNameRequest Create()
		{
			return new BabelTowerShowNameRequest();
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B08 RID: 11016 RVA: 0x000706E0 File Offset: 0x0006E8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x000706E3 File Offset: 0x0006E8E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerShowNameRequest.Descriptor;
			}
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000706EA File Offset: 0x0006E8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest()
		{
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000706F2 File Offset: 0x0006E8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest(BabelTowerShowNameRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00070723 File Offset: 0x0006E923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest Clone()
		{
			return new BabelTowerShowNameRequest(this);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B0D RID: 11021 RVA: 0x0007072B File Offset: 0x0006E92B
		// (set) Token: 0x06002B0E RID: 11022 RVA: 0x00070733 File Offset: 0x0006E933
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x0007073C File Offset: 0x0006E93C
		// (set) Token: 0x06002B10 RID: 11024 RVA: 0x00070744 File Offset: 0x0006E944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0007074D File Offset: 0x0006E94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerShowNameRequest);
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0007075B File Offset: 0x0006E95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerShowNameRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0007079C File Offset: 0x0006E99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000707F4 File Offset: 0x0006E9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00070801 File Offset: 0x0006EA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x0007080C File Offset: 0x0006EA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00070868 File Offset: 0x0006EA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000708B4 File Offset: 0x0006EAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerShowNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00070904 File Offset: 0x0006EB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00070910 File Offset: 0x0006EB10
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ShowName = input.ReadBool();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002785 RID: 10117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002786 RID: 10118
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04002787 RID: 10119
		private int activityId_;

		// Token: 0x04002788 RID: 10120
		public const int ShowNameFieldNumber = 5;

		// Token: 0x04002789 RID: 10121
		private bool showName_;
	}
}
