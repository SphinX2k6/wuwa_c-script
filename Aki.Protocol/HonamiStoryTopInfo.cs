using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000794 RID: 1940
	public sealed class HonamiStoryTopInfo : IMessage<HonamiStoryTopInfo>, IMessage, IEquatable<HonamiStoryTopInfo>, IDeepCloneable<HonamiStoryTopInfo>, IBufferMessage
	{
		// Token: 0x0600AF4B RID: 44875 RVA: 0x001A4E9D File Offset: 0x001A309D
		[NullableContext(1)]
		public static HonamiStoryTopInfo Create()
		{
			return new HonamiStoryTopInfo();
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x001A4EA4 File Offset: 0x001A30A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryTopInfo> Parser
		{
			get
			{
				return HonamiStoryTopInfo._parser;
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x0600AF4D RID: 44877 RVA: 0x001A4EAB File Offset: 0x001A30AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x001A4EAE File Offset: 0x001A30AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTopInfo.Descriptor;
			}
		}

		// Token: 0x0600AF4F RID: 44879 RVA: 0x001A4EB5 File Offset: 0x001A30B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo()
		{
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x001A4EBD File Offset: 0x001A30BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo(HonamiStoryTopInfo other) : this()
		{
			this.dangerLevel_ = other.dangerLevel_;
			this.maxFloor_ = other.maxFloor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x001A4EEE File Offset: 0x001A30EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo Clone()
		{
			return new HonamiStoryTopInfo(this);
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x001A4EF6 File Offset: 0x001A30F6
		// (set) Token: 0x0600AF53 RID: 44883 RVA: 0x001A4EFE File Offset: 0x001A30FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangerLevel
		{
			get
			{
				return this.dangerLevel_;
			}
			set
			{
				this.dangerLevel_ = value;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x001A4F07 File Offset: 0x001A3107
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x001A4F0F File Offset: 0x001A310F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxFloor
		{
			get
			{
				return this.maxFloor_;
			}
			set
			{
				this.maxFloor_ = value;
			}
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x001A4F18 File Offset: 0x001A3118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTopInfo);
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x001A4F26 File Offset: 0x001A3126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTopInfo other)
		{
			return other != null && (other == this || (this.DangerLevel == other.DangerLevel && this.MaxFloor == other.MaxFloor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x001A4F64 File Offset: 0x001A3164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangerLevel != 0)
			{
				num ^= this.DangerLevel.GetHashCode();
			}
			if (this.MaxFloor != 0)
			{
				num ^= this.MaxFloor.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x001A4FBC File Offset: 0x001A31BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x001A4FC9 File Offset: 0x001A31C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x001A4FD4 File Offset: 0x001A31D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangerLevel != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangerLevel);
			}
			if (this.MaxFloor != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxFloor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x001A502C File Offset: 0x001A322C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangerLevel);
			}
			if (this.MaxFloor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxFloor);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x001A5084 File Offset: 0x001A3284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangerLevel != 0)
			{
				this.DangerLevel = other.DangerLevel;
			}
			if (other.MaxFloor != 0)
			{
				this.MaxFloor = other.MaxFloor;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x001A50D4 File Offset: 0x001A32D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF5F RID: 44895 RVA: 0x001A50E0 File Offset: 0x001A32E0
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
						this.MaxFloor = input.ReadInt32();
					}
				}
				else
				{
					this.DangerLevel = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F48 RID: 20296
		private static readonly MessageParser<HonamiStoryTopInfo> _parser = new MessageParser<HonamiStoryTopInfo>(() => new HonamiStoryTopInfo());

		// Token: 0x04004F49 RID: 20297
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F4A RID: 20298
		public const int DangerLevelFieldNumber = 1;

		// Token: 0x04004F4B RID: 20299
		private int dangerLevel_;

		// Token: 0x04004F4C RID: 20300
		public const int MaxFloorFieldNumber = 2;

		// Token: 0x04004F4D RID: 20301
		private int maxFloor_;
	}
}
