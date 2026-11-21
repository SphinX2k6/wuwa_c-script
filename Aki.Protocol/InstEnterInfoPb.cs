using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080C RID: 2060
	public sealed class InstEnterInfoPb : IMessage<InstEnterInfoPb>, IMessage, IEquatable<InstEnterInfoPb>, IDeepCloneable<InstEnterInfoPb>, IBufferMessage
	{
		// Token: 0x0600B882 RID: 47234 RVA: 0x001B7A60 File Offset: 0x001B5C60
		[NullableContext(1)]
		public static InstEnterInfoPb Create()
		{
			return new InstEnterInfoPb();
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x0600B883 RID: 47235 RVA: 0x001B7A67 File Offset: 0x001B5C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstEnterInfoPb> Parser
		{
			get
			{
				return InstEnterInfoPb._parser;
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x001B7A6E File Offset: 0x001B5C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x0600B885 RID: 47237 RVA: 0x001B7A71 File Offset: 0x001B5C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEnterInfoPb.Descriptor;
			}
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x001B7A78 File Offset: 0x001B5C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb()
		{
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x001B7A80 File Offset: 0x001B5C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb(InstEnterInfoPb other) : this()
		{
			this.id_ = other.id_;
			this.enterCount_ = other.enterCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x001B7AB1 File Offset: 0x001B5CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb Clone()
		{
			return new InstEnterInfoPb(this);
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x0600B889 RID: 47241 RVA: 0x001B7AB9 File Offset: 0x001B5CB9
		// (set) Token: 0x0600B88A RID: 47242 RVA: 0x001B7AC1 File Offset: 0x001B5CC1
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

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x0600B88B RID: 47243 RVA: 0x001B7ACA File Offset: 0x001B5CCA
		// (set) Token: 0x0600B88C RID: 47244 RVA: 0x001B7AD2 File Offset: 0x001B5CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EnterCount
		{
			get
			{
				return this.enterCount_;
			}
			set
			{
				this.enterCount_ = value;
			}
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x001B7ADB File Offset: 0x001B5CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEnterInfoPb);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x001B7AE9 File Offset: 0x001B5CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEnterInfoPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EnterCount == other.EnterCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x001B7B28 File Offset: 0x001B5D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EnterCount != 0)
			{
				num ^= this.EnterCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x001B7B80 File Offset: 0x001B5D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x001B7B8D File Offset: 0x001B5D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x001B7B98 File Offset: 0x001B5D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.EnterCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EnterCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x001B7BF0 File Offset: 0x001B5DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.EnterCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EnterCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x001B7C48 File Offset: 0x001B5E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEnterInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EnterCount != 0)
			{
				this.EnterCount = other.EnterCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x001B7C98 File Offset: 0x001B5E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x001B7CA4 File Offset: 0x001B5EA4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EnterCount = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005197 RID: 20887
		private static readonly MessageParser<InstEnterInfoPb> _parser = new MessageParser<InstEnterInfoPb>(() => new InstEnterInfoPb());

		// Token: 0x04005198 RID: 20888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005199 RID: 20889
		public const int IdFieldNumber = 1;

		// Token: 0x0400519A RID: 20890
		private int id_;

		// Token: 0x0400519B RID: 20891
		public const int EnterCountFieldNumber = 2;

		// Token: 0x0400519C RID: 20892
		private int enterCount_;
	}
}
