using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000385 RID: 901
	[NetMessage(EMessageId.DangoMonopolyDiceRequest)]
	public sealed class DangoMonopolyDiceRequest : IMessage<DangoMonopolyDiceRequest>, IMessage, IEquatable<DangoMonopolyDiceRequest>, IDeepCloneable<DangoMonopolyDiceRequest>, IBufferMessage
	{
		// Token: 0x0600592F RID: 22831 RVA: 0x000D9488 File Offset: 0x000D7688
		[NullableContext(1)]
		public static DangoMonopolyDiceRequest Create()
		{
			return new DangoMonopolyDiceRequest();
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06005930 RID: 22832 RVA: 0x000D948F File Offset: 0x000D768F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06005931 RID: 22833 RVA: 0x000D9492 File Offset: 0x000D7692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyDiceRequest.Descriptor;
			}
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x000D9499 File Offset: 0x000D7699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest()
		{
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x000D94A1 File Offset: 0x000D76A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest(DangoMonopolyDiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x000D94C6 File Offset: 0x000D76C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyDiceRequest Clone()
		{
			return new DangoMonopolyDiceRequest(this);
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x000D94CE File Offset: 0x000D76CE
		// (set) Token: 0x06005936 RID: 22838 RVA: 0x000D94D6 File Offset: 0x000D76D6
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

		// Token: 0x06005937 RID: 22839 RVA: 0x000D94DF File Offset: 0x000D76DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyDiceRequest);
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x000D94ED File Offset: 0x000D76ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyDiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x000D951C File Offset: 0x000D771C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x000D955B File Offset: 0x000D775B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x000D9568 File Offset: 0x000D7768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x000D9571 File Offset: 0x000D7771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x000D95A4 File Offset: 0x000D77A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x000D95E2 File Offset: 0x000D77E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyDiceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x000D9613 File Offset: 0x000D7813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x000D961C File Offset: 0x000D781C
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003552 RID: 13650
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003553 RID: 13651
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04003554 RID: 13652
		private int activityId_;
	}
}
