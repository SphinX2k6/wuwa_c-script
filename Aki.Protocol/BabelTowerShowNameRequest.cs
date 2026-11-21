using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000156 RID: 342
	[NetMessage(EMessageId.BabelTowerShowNameRequest)]
	public sealed class BabelTowerShowNameRequest : IMessage<BabelTowerShowNameRequest>, IMessage, IEquatable<BabelTowerShowNameRequest>, IDeepCloneable<BabelTowerShowNameRequest>, IBufferMessage
	{
		// Token: 0x06002B7E RID: 11134 RVA: 0x00071B09 File Offset: 0x0006FD09
		[NullableContext(1)]
		public static BabelTowerShowNameRequest Create()
		{
			return new BabelTowerShowNameRequest();
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00071B10 File Offset: 0x0006FD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002B80 RID: 11136 RVA: 0x00071B13 File Offset: 0x0006FD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerShowNameRequest.Descriptor;
			}
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00071B1A File Offset: 0x0006FD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest()
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00071B22 File Offset: 0x0006FD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest(BabelTowerShowNameRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00071B53 File Offset: 0x0006FD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerShowNameRequest Clone()
		{
			return new BabelTowerShowNameRequest(this);
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x00071B5B File Offset: 0x0006FD5B
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00071B63 File Offset: 0x0006FD63
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x00071B6C File Offset: 0x0006FD6C
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x00071B74 File Offset: 0x0006FD74
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

		// Token: 0x06002B88 RID: 11144 RVA: 0x00071B7D File Offset: 0x0006FD7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerShowNameRequest);
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00071B8B File Offset: 0x0006FD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerShowNameRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00071BCC File Offset: 0x0006FDCC
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

		// Token: 0x06002B8B RID: 11147 RVA: 0x00071C24 File Offset: 0x0006FE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00071C31 File Offset: 0x0006FE31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00071C3C File Offset: 0x0006FE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowName)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ShowName);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00071C94 File Offset: 0x0006FE94
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

		// Token: 0x06002B8F RID: 11151 RVA: 0x00071CE0 File Offset: 0x0006FEE0
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

		// Token: 0x06002B90 RID: 11152 RVA: 0x00071D30 File Offset: 0x0006FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00071D3C File Offset: 0x0006FF3C
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ShowName = input.ReadBool();
				}
			}
		}

		// Token: 0x040027F9 RID: 10233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027FA RID: 10234
		public const int ActivityIdFieldNumber = 9;

		// Token: 0x040027FB RID: 10235
		private int activityId_;

		// Token: 0x040027FC RID: 10236
		public const int ShowNameFieldNumber = 1;

		// Token: 0x040027FD RID: 10237
		private bool showName_;
	}
}
