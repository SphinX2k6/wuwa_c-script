using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A2 RID: 1954
	[NetMessage(EMessageId.HookLockPointFinishRequest)]
	public sealed class HookLockPointFinishRequest : IMessage<HookLockPointFinishRequest>, IMessage, IEquatable<HookLockPointFinishRequest>, IDeepCloneable<HookLockPointFinishRequest>, IBufferMessage
	{
		// Token: 0x0600B06B RID: 45163 RVA: 0x001A75B5 File Offset: 0x001A57B5
		[NullableContext(1)]
		public static HookLockPointFinishRequest Create()
		{
			return new HookLockPointFinishRequest();
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x001A75BC File Offset: 0x001A57BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x001A75BF File Offset: 0x001A57BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointFinishRequest.Descriptor;
			}
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x001A75C6 File Offset: 0x001A57C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest()
		{
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x001A75CE File Offset: 0x001A57CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest(HookLockPointFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x001A75F3 File Offset: 0x001A57F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishRequest Clone()
		{
			return new HookLockPointFinishRequest(this);
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x001A75FB File Offset: 0x001A57FB
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x001A7603 File Offset: 0x001A5803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x001A760C File Offset: 0x001A580C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointFinishRequest);
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x001A761A File Offset: 0x001A581A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B075 RID: 45173 RVA: 0x001A7648 File Offset: 0x001A5848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B076 RID: 45174 RVA: 0x001A7687 File Offset: 0x001A5887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x001A7694 File Offset: 0x001A5894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x001A769D File Offset: 0x001A589D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B079 RID: 45177 RVA: 0x001A76D0 File Offset: 0x001A58D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B07A RID: 45178 RVA: 0x001A770E File Offset: 0x001A590E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B07B RID: 45179 RVA: 0x001A773F File Offset: 0x001A593F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B07C RID: 45180 RVA: 0x001A7748 File Offset: 0x001A5948
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004F99 RID: 20377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F9A RID: 20378
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04004F9B RID: 20379
		private long entityId_;
	}
}
