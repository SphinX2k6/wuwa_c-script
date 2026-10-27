using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000820 RID: 2080
	public sealed class InstEnterInfoPb : IMessage<InstEnterInfoPb>, IMessage, IEquatable<InstEnterInfoPb>, IDeepCloneable<InstEnterInfoPb>, IBufferMessage
	{
		// Token: 0x0600B9D8 RID: 47576 RVA: 0x001BA49C File Offset: 0x001B869C
		[NullableContext(1)]
		public static InstEnterInfoPb Create()
		{
			return new InstEnterInfoPb();
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x001BA4A3 File Offset: 0x001B86A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InstEnterInfoPb> Parser
		{
			get
			{
				return InstEnterInfoPb._parser;
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x001BA4AA File Offset: 0x001B86AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x001BA4AD File Offset: 0x001B86AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEnterInfoPb.Descriptor;
			}
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x001BA4B4 File Offset: 0x001B86B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb()
		{
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x001BA4BC File Offset: 0x001B86BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb(InstEnterInfoPb other) : this()
		{
			this.id_ = other.id_;
			this.enterCount_ = other.enterCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x001BA4ED File Offset: 0x001B86ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEnterInfoPb Clone()
		{
			return new InstEnterInfoPb(this);
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x001BA4F5 File Offset: 0x001B86F5
		// (set) Token: 0x0600B9E0 RID: 47584 RVA: 0x001BA4FD File Offset: 0x001B86FD
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

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x001BA506 File Offset: 0x001B8706
		// (set) Token: 0x0600B9E2 RID: 47586 RVA: 0x001BA50E File Offset: 0x001B870E
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

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x001BA517 File Offset: 0x001B8717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEnterInfoPb);
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x001BA525 File Offset: 0x001B8725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEnterInfoPb other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EnterCount == other.EnterCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x001BA564 File Offset: 0x001B8764
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

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x001BA5BC File Offset: 0x001B87BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x001BA5C9 File Offset: 0x001B87C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x001BA5D4 File Offset: 0x001B87D4
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

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x001BA62C File Offset: 0x001B882C
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

		// Token: 0x0600B9EA RID: 47594 RVA: 0x001BA684 File Offset: 0x001B8884
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

		// Token: 0x0600B9EB RID: 47595 RVA: 0x001BA6D4 File Offset: 0x001B88D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x001BA6E0 File Offset: 0x001B88E0
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

		// Token: 0x0400519E RID: 20894
		private static readonly MessageParser<InstEnterInfoPb> _parser = new MessageParser<InstEnterInfoPb>(() => new InstEnterInfoPb());

		// Token: 0x0400519F RID: 20895
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A0 RID: 20896
		public const int IdFieldNumber = 1;

		// Token: 0x040051A1 RID: 20897
		private int id_;

		// Token: 0x040051A2 RID: 20898
		public const int EnterCountFieldNumber = 2;

		// Token: 0x040051A3 RID: 20899
		private int enterCount_;
	}
}
