using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EC RID: 2284
	[NetMessage(EMessageId.LeaveLevelPlayNotify)]
	public sealed class LeaveLevelPlayNotify : IMessage<LeaveLevelPlayNotify>, IMessage, IEquatable<LeaveLevelPlayNotify>, IDeepCloneable<LeaveLevelPlayNotify>, IBufferMessage
	{
		// Token: 0x0600C9FE RID: 51710 RVA: 0x001DD3A9 File Offset: 0x001DB5A9
		[NullableContext(1)]
		public static LeaveLevelPlayNotify Create()
		{
			return new LeaveLevelPlayNotify();
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600C9FF RID: 51711 RVA: 0x001DD3B0 File Offset: 0x001DB5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600CA00 RID: 51712 RVA: 0x001DD3B3 File Offset: 0x001DB5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveLevelPlayNotify.Descriptor;
			}
		}

		// Token: 0x0600CA01 RID: 51713 RVA: 0x001DD3BA File Offset: 0x001DB5BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify()
		{
		}

		// Token: 0x0600CA02 RID: 51714 RVA: 0x001DD3C2 File Offset: 0x001DB5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify(LeaveLevelPlayNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA03 RID: 51715 RVA: 0x001DD3E7 File Offset: 0x001DB5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveLevelPlayNotify Clone()
		{
			return new LeaveLevelPlayNotify(this);
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600CA04 RID: 51716 RVA: 0x001DD3EF File Offset: 0x001DB5EF
		// (set) Token: 0x0600CA05 RID: 51717 RVA: 0x001DD3F7 File Offset: 0x001DB5F7
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

		// Token: 0x0600CA06 RID: 51718 RVA: 0x001DD400 File Offset: 0x001DB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveLevelPlayNotify);
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x001DD40E File Offset: 0x001DB60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveLevelPlayNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x001DD43C File Offset: 0x001DB63C
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

		// Token: 0x0600CA09 RID: 51721 RVA: 0x001DD47B File Offset: 0x001DB67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x001DD488 File Offset: 0x001DB688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x001DD491 File Offset: 0x001DB691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x001DD4C4 File Offset: 0x001DB6C4
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

		// Token: 0x0600CA0D RID: 51725 RVA: 0x001DD502 File Offset: 0x001DB702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveLevelPlayNotify other)
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

		// Token: 0x0600CA0E RID: 51726 RVA: 0x001DD533 File Offset: 0x001DB733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x001DD53C File Offset: 0x001DB73C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400560F RID: 22031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005610 RID: 22032
		public const int IdFieldNumber = 10;

		// Token: 0x04005611 RID: 22033
		private int id_;
	}
}
