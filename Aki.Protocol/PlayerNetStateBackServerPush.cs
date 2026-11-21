using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D8C RID: 3468
	[NetMessage(EMessageId.PlayerNetStateBackServerPush)]
	public sealed class PlayerNetStateBackServerPush : IMessage<PlayerNetStateBackServerPush>, IMessage, IEquatable<PlayerNetStateBackServerPush>, IDeepCloneable<PlayerNetStateBackServerPush>, IBufferMessage
	{
		// Token: 0x06012B7E RID: 76670 RVA: 0x002BBB81 File Offset: 0x002B9D81
		[NullableContext(1)]
		public static PlayerNetStateBackServerPush Create()
		{
			return new PlayerNetStateBackServerPush();
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x06012B7F RID: 76671 RVA: 0x002BBB88 File Offset: 0x002B9D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x06012B80 RID: 76672 RVA: 0x002BBB8B File Offset: 0x002B9D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerNetStateBackServerPush.Descriptor;
			}
		}

		// Token: 0x06012B81 RID: 76673 RVA: 0x002BBB92 File Offset: 0x002B9D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush()
		{
		}

		// Token: 0x06012B82 RID: 76674 RVA: 0x002BBB9A File Offset: 0x002B9D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush(PlayerNetStateBackServerPush other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B83 RID: 76675 RVA: 0x002BBBBF File Offset: 0x002B9DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerNetStateBackServerPush Clone()
		{
			return new PlayerNetStateBackServerPush(this);
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x06012B84 RID: 76676 RVA: 0x002BBBC7 File Offset: 0x002B9DC7
		// (set) Token: 0x06012B85 RID: 76677 RVA: 0x002BBBCF File Offset: 0x002B9DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x06012B86 RID: 76678 RVA: 0x002BBBD8 File Offset: 0x002B9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerNetStateBackServerPush);
		}

		// Token: 0x06012B87 RID: 76679 RVA: 0x002BBBE6 File Offset: 0x002B9DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerNetStateBackServerPush other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B88 RID: 76680 RVA: 0x002BBC14 File Offset: 0x002B9E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0L)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B89 RID: 76681 RVA: 0x002BBC53 File Offset: 0x002B9E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B8A RID: 76682 RVA: 0x002BBC60 File Offset: 0x002B9E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B8B RID: 76683 RVA: 0x002BBC69 File Offset: 0x002B9E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x002BBC9C File Offset: 0x002B9E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x002BBCDA File Offset: 0x002B9EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerNetStateBackServerPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0L)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x002BBD0B File Offset: 0x002B9F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B8F RID: 76687 RVA: 0x002BBD14 File Offset: 0x002B9F14
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007478 RID: 29816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007479 RID: 29817
		public const int UidFieldNumber = 8;

		// Token: 0x0400747A RID: 29818
		private long uid_;
	}
}
