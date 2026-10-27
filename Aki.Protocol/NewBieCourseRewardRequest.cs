using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B09 RID: 2825
	[NetMessage(EMessageId.NewBieCourseRewardRequest)]
	public sealed class NewBieCourseRewardRequest : IMessage<NewBieCourseRewardRequest>, IMessage, IEquatable<NewBieCourseRewardRequest>, IDeepCloneable<NewBieCourseRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F574 RID: 62836 RVA: 0x0023D085 File Offset: 0x0023B285
		[NullableContext(1)]
		public static NewBieCourseRewardRequest Create()
		{
			return new NewBieCourseRewardRequest();
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0600F575 RID: 62837 RVA: 0x0023D08C File Offset: 0x0023B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0600F576 RID: 62838 RVA: 0x0023D08F File Offset: 0x0023B28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F577 RID: 62839 RVA: 0x0023D096 File Offset: 0x0023B296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest()
		{
		}

		// Token: 0x0600F578 RID: 62840 RVA: 0x0023D09E File Offset: 0x0023B29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest(NewBieCourseRewardRequest other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F579 RID: 62841 RVA: 0x0023D0C3 File Offset: 0x0023B2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardRequest Clone()
		{
			return new NewBieCourseRewardRequest(this);
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0600F57A RID: 62842 RVA: 0x0023D0CB File Offset: 0x0023B2CB
		// (set) Token: 0x0600F57B RID: 62843 RVA: 0x0023D0D3 File Offset: 0x0023B2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600F57C RID: 62844 RVA: 0x0023D0DC File Offset: 0x0023B2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardRequest);
		}

		// Token: 0x0600F57D RID: 62845 RVA: 0x0023D0EA File Offset: 0x0023B2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardRequest other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F57E RID: 62846 RVA: 0x0023D118 File Offset: 0x0023B318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F57F RID: 62847 RVA: 0x0023D157 File Offset: 0x0023B357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F580 RID: 62848 RVA: 0x0023D164 File Offset: 0x0023B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F581 RID: 62849 RVA: 0x0023D16D File Offset: 0x0023B36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F582 RID: 62850 RVA: 0x0023D1A0 File Offset: 0x0023B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F583 RID: 62851 RVA: 0x0023D1DE File Offset: 0x0023B3DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F584 RID: 62852 RVA: 0x0023D20F File Offset: 0x0023B40F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F585 RID: 62853 RVA: 0x0023D218 File Offset: 0x0023B418
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
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062B4 RID: 25268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062B5 RID: 25269
		public const int LevelFieldNumber = 7;

		// Token: 0x040062B6 RID: 25270
		private int level_;
	}
}
