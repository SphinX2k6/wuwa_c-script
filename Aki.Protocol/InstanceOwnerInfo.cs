using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000807 RID: 2055
	public sealed class InstanceOwnerInfo : IMessage<InstanceOwnerInfo>, IMessage, IEquatable<InstanceOwnerInfo>, IDeepCloneable<InstanceOwnerInfo>, IBufferMessage
	{
		// Token: 0x0600B81C RID: 47132 RVA: 0x001B6DE7 File Offset: 0x001B4FE7
		[NullableContext(1)]
		public static InstanceOwnerInfo Create()
		{
			return new InstanceOwnerInfo();
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600B81D RID: 47133 RVA: 0x001B6DEE File Offset: 0x001B4FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600B81E RID: 47134 RVA: 0x001B6DF1 File Offset: 0x001B4FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstanceOwnerInfo.Descriptor;
			}
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x001B6DF8 File Offset: 0x001B4FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo()
		{
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x001B6E00 File Offset: 0x001B5000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo(InstanceOwnerInfo other) : this()
		{
			this.isFinishMingSuGen_ = other.isFinishMingSuGen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x001B6E25 File Offset: 0x001B5025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstanceOwnerInfo Clone()
		{
			return new InstanceOwnerInfo(this);
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x001B6E2D File Offset: 0x001B502D
		// (set) Token: 0x0600B823 RID: 47139 RVA: 0x001B6E35 File Offset: 0x001B5035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinishMingSuGen
		{
			get
			{
				return this.isFinishMingSuGen_;
			}
			set
			{
				this.isFinishMingSuGen_ = value;
			}
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x001B6E3E File Offset: 0x001B503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstanceOwnerInfo);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x001B6E4C File Offset: 0x001B504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstanceOwnerInfo other)
		{
			return other != null && (other == this || (this.IsFinishMingSuGen == other.IsFinishMingSuGen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x001B6E7C File Offset: 0x001B507C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsFinishMingSuGen)
			{
				num ^= this.IsFinishMingSuGen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x001B6EBB File Offset: 0x001B50BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x001B6EC8 File Offset: 0x001B50C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x001B6ED1 File Offset: 0x001B50D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsFinishMingSuGen)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsFinishMingSuGen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x001B6F04 File Offset: 0x001B5104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsFinishMingSuGen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x001B6F36 File Offset: 0x001B5136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstanceOwnerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsFinishMingSuGen)
			{
				this.IsFinishMingSuGen = other.IsFinishMingSuGen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x001B6F67 File Offset: 0x001B5167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x001B6F70 File Offset: 0x001B5170
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
					this.IsFinishMingSuGen = input.ReadBool();
				}
			}
		}

		// Token: 0x0400517C RID: 20860
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400517D RID: 20861
		public const int IsFinishMingSuGenFieldNumber = 1;

		// Token: 0x0400517E RID: 20862
		private bool isFinishMingSuGen_;
	}
}
