using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087A RID: 2170
	public sealed class KurotatoChestRewardStepPbData : IMessage<KurotatoChestRewardStepPbData>, IMessage, IEquatable<KurotatoChestRewardStepPbData>, IDeepCloneable<KurotatoChestRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0600C17B RID: 49531 RVA: 0x001CBFA5 File Offset: 0x001CA1A5
		[NullableContext(1)]
		public static KurotatoChestRewardStepPbData Create()
		{
			return new KurotatoChestRewardStepPbData();
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600C17C RID: 49532 RVA: 0x001CBFAC File Offset: 0x001CA1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600C17D RID: 49533 RVA: 0x001CBFAF File Offset: 0x001CA1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoChestRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x001CBFB6 File Offset: 0x001CA1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData()
		{
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x001CBFBE File Offset: 0x001CA1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData(KurotatoChestRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x001CBFD7 File Offset: 0x001CA1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoChestRewardStepPbData Clone()
		{
			return new KurotatoChestRewardStepPbData(this);
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x001CBFDF File Offset: 0x001CA1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoChestRewardStepPbData);
		}

		// Token: 0x0600C182 RID: 49538 RVA: 0x001CBFED File Offset: 0x001CA1ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoChestRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x001CC00C File Offset: 0x001CA20C
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

		// Token: 0x0600C184 RID: 49540 RVA: 0x001CC032 File Offset: 0x001CA232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x001CC03F File Offset: 0x001CA23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x001CC048 File Offset: 0x001CA248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x001CC060 File Offset: 0x001CA260
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

		// Token: 0x0600C188 RID: 49544 RVA: 0x001CC086 File Offset: 0x001CA286
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

		// Token: 0x0600C189 RID: 49545 RVA: 0x001CC0A3 File Offset: 0x001CA2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C18A RID: 49546 RVA: 0x001CC0AC File Offset: 0x001CA2AC
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

		// Token: 0x0400544D RID: 21581
		private UnknownFieldSet _unknownFields;
	}
}
