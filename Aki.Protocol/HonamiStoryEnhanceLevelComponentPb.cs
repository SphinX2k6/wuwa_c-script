using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000774 RID: 1908
	public sealed class HonamiStoryEnhanceLevelComponentPb : IMessage<HonamiStoryEnhanceLevelComponentPb>, IMessage, IEquatable<HonamiStoryEnhanceLevelComponentPb>, IDeepCloneable<HonamiStoryEnhanceLevelComponentPb>, IBufferMessage
	{
		// Token: 0x0600AC71 RID: 44145 RVA: 0x0019E824 File Offset: 0x0019CA24
		[NullableContext(1)]
		public static HonamiStoryEnhanceLevelComponentPb Create()
		{
			return new HonamiStoryEnhanceLevelComponentPb();
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x0019E82B File Offset: 0x0019CA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x0019E82E File Offset: 0x0019CA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEnhanceLevelComponentPb.Descriptor;
			}
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x0019E835 File Offset: 0x0019CA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb()
		{
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x0019E83D File Offset: 0x0019CA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb(HonamiStoryEnhanceLevelComponentPb other) : this()
		{
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x0019E862 File Offset: 0x0019CA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb Clone()
		{
			return new HonamiStoryEnhanceLevelComponentPb(this);
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600AC77 RID: 44151 RVA: 0x0019E86A File Offset: 0x0019CA6A
		// (set) Token: 0x0600AC78 RID: 44152 RVA: 0x0019E872 File Offset: 0x0019CA72
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

		// Token: 0x0600AC79 RID: 44153 RVA: 0x0019E87B File Offset: 0x0019CA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEnhanceLevelComponentPb);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x0019E889 File Offset: 0x0019CA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEnhanceLevelComponentPb other)
		{
			return other != null && (other == this || (this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x0019E8B8 File Offset: 0x0019CAB8
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

		// Token: 0x0600AC7C RID: 44156 RVA: 0x0019E8F7 File Offset: 0x0019CAF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x0019E904 File Offset: 0x0019CB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x0019E90D File Offset: 0x0019CB0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x0019E940 File Offset: 0x0019CB40
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

		// Token: 0x0600AC80 RID: 44160 RVA: 0x0019E97E File Offset: 0x0019CB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEnhanceLevelComponentPb other)
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

		// Token: 0x0600AC81 RID: 44161 RVA: 0x0019E9AF File Offset: 0x0019CBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x0019E9B8 File Offset: 0x0019CBB8
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
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E16 RID: 19990
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E17 RID: 19991
		public const int LevelFieldNumber = 1;

		// Token: 0x04004E18 RID: 19992
		private int level_;
	}
}
