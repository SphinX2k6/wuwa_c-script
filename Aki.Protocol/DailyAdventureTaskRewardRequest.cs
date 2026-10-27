using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000320 RID: 800
	[NetMessage(EMessageId.DailyAdventureTaskRewardRequest)]
	public sealed class DailyAdventureTaskRewardRequest : IMessage<DailyAdventureTaskRewardRequest>, IMessage, IEquatable<DailyAdventureTaskRewardRequest>, IDeepCloneable<DailyAdventureTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06005086 RID: 20614 RVA: 0x000C44A9 File Offset: 0x000C26A9
		[NullableContext(1)]
		public static DailyAdventureTaskRewardRequest Create()
		{
			return new DailyAdventureTaskRewardRequest();
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x000C44B0 File Offset: 0x000C26B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06005088 RID: 20616 RVA: 0x000C44B3 File Offset: 0x000C26B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x000C44BA File Offset: 0x000C26BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest()
		{
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x000C44C2 File Offset: 0x000C26C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest(DailyAdventureTaskRewardRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x000C44E7 File Offset: 0x000C26E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskRewardRequest Clone()
		{
			return new DailyAdventureTaskRewardRequest(this);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x000C44EF File Offset: 0x000C26EF
		// (set) Token: 0x0600508D RID: 20621 RVA: 0x000C44F7 File Offset: 0x000C26F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x000C4500 File Offset: 0x000C2700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskRewardRequest);
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x000C450E File Offset: 0x000C270E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskRewardRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005090 RID: 20624 RVA: 0x000C453C File Offset: 0x000C273C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005091 RID: 20625 RVA: 0x000C457B File Offset: 0x000C277B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005092 RID: 20626 RVA: 0x000C4588 File Offset: 0x000C2788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005093 RID: 20627 RVA: 0x000C4591 File Offset: 0x000C2791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005094 RID: 20628 RVA: 0x000C45C4 File Offset: 0x000C27C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x000C4602 File Offset: 0x000C2802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x000C4633 File Offset: 0x000C2833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x000C463C File Offset: 0x000C283C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400326B RID: 12907
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400326C RID: 12908
		public const int IdFieldNumber = 2;

		// Token: 0x0400326D RID: 12909
		private int id_;
	}
}
