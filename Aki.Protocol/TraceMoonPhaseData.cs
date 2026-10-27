using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D2 RID: 5074
	public sealed class TraceMoonPhaseData : IMessage<TraceMoonPhaseData>, IMessage, IEquatable<TraceMoonPhaseData>, IDeepCloneable<TraceMoonPhaseData>, IBufferMessage
	{
		// Token: 0x0601AE8D RID: 110221 RVA: 0x003E68AB File Offset: 0x003E4AAB
		[NullableContext(1)]
		public static TraceMoonPhaseData Create()
		{
			return new TraceMoonPhaseData();
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x0601AE8E RID: 110222 RVA: 0x003E68B2 File Offset: 0x003E4AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x0601AE8F RID: 110223 RVA: 0x003E68B5 File Offset: 0x003E4AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceMoonPhaseData.Descriptor;
			}
		}

		// Token: 0x0601AE90 RID: 110224 RVA: 0x003E68BC File Offset: 0x003E4ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData()
		{
		}

		// Token: 0x0601AE91 RID: 110225 RVA: 0x003E68C4 File Offset: 0x003E4AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData(TraceMoonPhaseData other) : this()
		{
			this.reward_ = other.reward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE92 RID: 110226 RVA: 0x003E68E9 File Offset: 0x003E4AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceMoonPhaseData Clone()
		{
			return new TraceMoonPhaseData(this);
		}

		// Token: 0x17005AC1 RID: 23233
		// (get) Token: 0x0601AE93 RID: 110227 RVA: 0x003E68F1 File Offset: 0x003E4AF1
		// (set) Token: 0x0601AE94 RID: 110228 RVA: 0x003E68F9 File Offset: 0x003E4AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x0601AE95 RID: 110229 RVA: 0x003E6902 File Offset: 0x003E4B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceMoonPhaseData);
		}

		// Token: 0x0601AE96 RID: 110230 RVA: 0x003E6910 File Offset: 0x003E4B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceMoonPhaseData other)
		{
			return other != null && (other == this || (this.Reward == other.Reward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE97 RID: 110231 RVA: 0x003E6940 File Offset: 0x003E4B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reward)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE98 RID: 110232 RVA: 0x003E697F File Offset: 0x003E4B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE99 RID: 110233 RVA: 0x003E698C File Offset: 0x003E4B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE9A RID: 110234 RVA: 0x003E6995 File Offset: 0x003E4B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reward)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE9B RID: 110235 RVA: 0x003E69C8 File Offset: 0x003E4BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE9C RID: 110236 RVA: 0x003E69FA File Offset: 0x003E4BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceMoonPhaseData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reward)
			{
				this.Reward = other.Reward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE9D RID: 110237 RVA: 0x003E6A2B File Offset: 0x003E4C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE9E RID: 110238 RVA: 0x003E6A34 File Offset: 0x003E4C34
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Reward = input.ReadBool();
				}
			}
		}

		// Token: 0x04009C0D RID: 39949
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C0E RID: 39950
		public const int RewardFieldNumber = 1;

		// Token: 0x04009C0F RID: 39951
		private bool reward_;
	}
}
