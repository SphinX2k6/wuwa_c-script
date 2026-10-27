using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD6 RID: 2774
	[NetMessage(EMessageId.MulCalabashLevelRewardRequest)]
	public sealed class MulCalabashLevelRewardRequest : IMessage<MulCalabashLevelRewardRequest>, IMessage, IEquatable<MulCalabashLevelRewardRequest>, IDeepCloneable<MulCalabashLevelRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F173 RID: 61811 RVA: 0x00234628 File Offset: 0x00232828
		[NullableContext(1)]
		public static MulCalabashLevelRewardRequest Create()
		{
			return new MulCalabashLevelRewardRequest();
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600F174 RID: 61812 RVA: 0x0023462F File Offset: 0x0023282F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600F175 RID: 61813 RVA: 0x00234632 File Offset: 0x00232832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulCalabashLevelRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F176 RID: 61814 RVA: 0x00234639 File Offset: 0x00232839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest()
		{
		}

		// Token: 0x0600F177 RID: 61815 RVA: 0x0023464C File Offset: 0x0023284C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest(MulCalabashLevelRewardRequest other) : this()
		{
			this.level_ = other.level_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F178 RID: 61816 RVA: 0x00234676 File Offset: 0x00232876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulCalabashLevelRewardRequest Clone()
		{
			return new MulCalabashLevelRewardRequest(this);
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600F179 RID: 61817 RVA: 0x0023467E File Offset: 0x0023287E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Level
		{
			get
			{
				return this.level_;
			}
		}

		// Token: 0x0600F17A RID: 61818 RVA: 0x00234686 File Offset: 0x00232886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulCalabashLevelRewardRequest);
		}

		// Token: 0x0600F17B RID: 61819 RVA: 0x00234694 File Offset: 0x00232894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulCalabashLevelRewardRequest other)
		{
			return other != null && (other == this || (this.level_.Equals(other.level_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F17C RID: 61820 RVA: 0x002346C8 File Offset: 0x002328C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.level_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F17D RID: 61821 RVA: 0x002346FC File Offset: 0x002328FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F17E RID: 61822 RVA: 0x00234709 File Offset: 0x00232909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F17F RID: 61823 RVA: 0x00234712 File Offset: 0x00232912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.level_.WriteTo(ref output, MulCalabashLevelRewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F180 RID: 61824 RVA: 0x0023473C File Offset: 0x0023293C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.level_.CalculateSize(MulCalabashLevelRewardRequest._repeated_level_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F181 RID: 61825 RVA: 0x00234775 File Offset: 0x00232975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulCalabashLevelRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.level_.Add(other.level_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F182 RID: 61826 RVA: 0x002347A3 File Offset: 0x002329A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F183 RID: 61827 RVA: 0x002347AC File Offset: 0x002329AC
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.level_.AddEntriesFrom(ref input, MulCalabashLevelRewardRequest._repeated_level_codec);
				}
			}
		}

		// Token: 0x0400618B RID: 24971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400618C RID: 24972
		public const int LevelFieldNumber = 11;

		// Token: 0x0400618D RID: 24973
		private static readonly FieldCodec<int> _repeated_level_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400618E RID: 24974
		private readonly RepeatedField<int> level_ = new RepeatedField<int>();
	}
}
