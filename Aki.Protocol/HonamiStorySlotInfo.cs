using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A5 RID: 1957
	public sealed class HonamiStorySlotInfo : IMessage<HonamiStorySlotInfo>, IMessage, IEquatable<HonamiStorySlotInfo>, IDeepCloneable<HonamiStorySlotInfo>, IBufferMessage
	{
		// Token: 0x0600B063 RID: 45155 RVA: 0x001A7183 File Offset: 0x001A5383
		[NullableContext(1)]
		public static HonamiStorySlotInfo Create()
		{
			return new HonamiStorySlotInfo();
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x001A718A File Offset: 0x001A538A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStorySlotInfo> Parser
		{
			get
			{
				return HonamiStorySlotInfo._parser;
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x0600B065 RID: 45157 RVA: 0x001A7191 File Offset: 0x001A5391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x0600B066 RID: 45158 RVA: 0x001A7194 File Offset: 0x001A5394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStorySlotInfo.Descriptor;
			}
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x001A719B File Offset: 0x001A539B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo()
		{
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x001A71A3 File Offset: 0x001A53A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo(HonamiStorySlotInfo other) : this()
		{
			this.slotId_ = other.slotId_;
			this.isUnlock_ = other.isUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x001A71D4 File Offset: 0x001A53D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStorySlotInfo Clone()
		{
			return new HonamiStorySlotInfo(this);
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x0600B06A RID: 45162 RVA: 0x001A71DC File Offset: 0x001A53DC
		// (set) Token: 0x0600B06B RID: 45163 RVA: 0x001A71E4 File Offset: 0x001A53E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x001A71ED File Offset: 0x001A53ED
		// (set) Token: 0x0600B06D RID: 45165 RVA: 0x001A71F5 File Offset: 0x001A53F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x001A71FE File Offset: 0x001A53FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStorySlotInfo);
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x001A720C File Offset: 0x001A540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStorySlotInfo other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.IsUnlock == other.IsUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x001A724C File Offset: 0x001A544C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x001A72A4 File Offset: 0x001A54A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x001A72B1 File Offset: 0x001A54B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x001A72BC File Offset: 0x001A54BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x001A7314 File Offset: 0x001A5514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B075 RID: 45173 RVA: 0x001A7360 File Offset: 0x001A5560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStorySlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B076 RID: 45174 RVA: 0x001A73B0 File Offset: 0x001A55B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x001A73BC File Offset: 0x001A55BC
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
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.SlotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F3F RID: 20287
		private static readonly MessageParser<HonamiStorySlotInfo> _parser = new MessageParser<HonamiStorySlotInfo>(() => new HonamiStorySlotInfo());

		// Token: 0x04004F40 RID: 20288
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F41 RID: 20289
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04004F42 RID: 20290
		private int slotId_;

		// Token: 0x04004F43 RID: 20291
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04004F44 RID: 20292
		private bool isUnlock_;
	}
}
