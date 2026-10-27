using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088B RID: 2187
	public sealed class KurotatoChestRewardStepPbData : IMessage<KurotatoChestRewardStepPbData>, IMessage, IEquatable<KurotatoChestRewardStepPbData>, IDeepCloneable<KurotatoChestRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0600C297 RID: 49815 RVA: 0x001CE28D File Offset: 0x001CC48D
		[NullableContext(1)]
		public static KurotatoChestRewardStepPbData Create()
		{
			return new KurotatoChestRewardStepPbData();
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600C298 RID: 49816 RVA: 0x001CE294 File Offset: 0x001CC494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600C299 RID: 49817 RVA: 0x001CE297 File Offset: 0x001CC497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C29A RID: 49818 RVA: 0x001CE29E File Offset: 0x001CC49E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData()
		{
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x001CE2A6 File Offset: 0x001CC4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData(KurotatoChestRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x001CE2BF File Offset: 0x001CC4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData Clone()
		{
			return new KurotatoChestRewardStepPbData(this);
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x001CE2C7 File Offset: 0x001CC4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardStepPbData);
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x001CE2D5 File Offset: 0x001CC4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x001CE2F4 File Offset: 0x001CC4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2A0 RID: 49824 RVA: 0x001CE31A File Offset: 0x001CC51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2A1 RID: 49825 RVA: 0x001CE327 File Offset: 0x001CC527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2A2 RID: 49826 RVA: 0x001CE330 File Offset: 0x001CC530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2A3 RID: 49827 RVA: 0x001CE348 File Offset: 0x001CC548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x001CE36E File Offset: 0x001CC56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoChestRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x001CE38B File Offset: 0x001CC58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x001CE394 File Offset: 0x001CC594
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005446 RID: 21574
		private UnknownFieldSet _unknownFields;
	}
}
