using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DC RID: 2268
	public sealed class KurotatoUpgradeRewardStepPbData : IMessage<KurotatoUpgradeRewardStepPbData>, IMessage, IEquatable<KurotatoUpgradeRewardStepPbData>, IDeepCloneable<KurotatoUpgradeRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0600C8CC RID: 51404 RVA: 0x001DAF41 File Offset: 0x001D9141
		[NullableContext(1)]
		public static KurotatoUpgradeRewardStepPbData Create()
		{
			return new KurotatoUpgradeRewardStepPbData();
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x001DAF48 File Offset: 0x001D9148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600C8CE RID: 51406 RVA: 0x001DAF4B File Offset: 0x001D914B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x001DAF52 File Offset: 0x001D9152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData()
		{
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x001DAF5A File Offset: 0x001D915A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData(KurotatoUpgradeRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8D1 RID: 51409 RVA: 0x001DAF73 File Offset: 0x001D9173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData Clone()
		{
			return new KurotatoUpgradeRewardStepPbData(this);
		}

		// Token: 0x0600C8D2 RID: 51410 RVA: 0x001DAF7B File Offset: 0x001D917B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardStepPbData);
		}

		// Token: 0x0600C8D3 RID: 51411 RVA: 0x001DAF89 File Offset: 0x001D9189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C8D4 RID: 51412 RVA: 0x001DAFA8 File Offset: 0x001D91A8
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

		// Token: 0x0600C8D5 RID: 51413 RVA: 0x001DAFCE File Offset: 0x001D91CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x001DAFDB File Offset: 0x001D91DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x001DAFE4 File Offset: 0x001D91E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x001DAFFC File Offset: 0x001D91FC
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

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x001DB022 File Offset: 0x001D9222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x001DB03F File Offset: 0x001D923F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x001DB048 File Offset: 0x001D9248
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

		// Token: 0x040055CB RID: 21963
		private UnknownFieldSet _unknownFields;
	}
}
