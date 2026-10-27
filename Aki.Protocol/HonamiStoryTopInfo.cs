using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A8 RID: 1960
	public sealed class HonamiStoryTopInfo : IMessage<HonamiStoryTopInfo>, IMessage, IEquatable<HonamiStoryTopInfo>, IDeepCloneable<HonamiStoryTopInfo>, IBufferMessage
	{
		// Token: 0x0600B0A1 RID: 45217 RVA: 0x001A78C9 File Offset: 0x001A5AC9
		[NullableContext(1)]
		public static HonamiStoryTopInfo Create()
		{
			return new HonamiStoryTopInfo();
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600B0A2 RID: 45218 RVA: 0x001A78D0 File Offset: 0x001A5AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryTopInfo> Parser
		{
			get
			{
				return HonamiStoryTopInfo._parser;
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600B0A3 RID: 45219 RVA: 0x001A78D7 File Offset: 0x001A5AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x001A78DA File Offset: 0x001A5ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTopInfo.Descriptor;
			}
		}

		// Token: 0x0600B0A5 RID: 45221 RVA: 0x001A78E1 File Offset: 0x001A5AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo()
		{
		}

		// Token: 0x0600B0A6 RID: 45222 RVA: 0x001A78E9 File Offset: 0x001A5AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo(HonamiStoryTopInfo other) : this()
		{
			this.dangerLevel_ = other.dangerLevel_;
			this.maxFloor_ = other.maxFloor_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0A7 RID: 45223 RVA: 0x001A791A File Offset: 0x001A5B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTopInfo Clone()
		{
			return new HonamiStoryTopInfo(this);
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x001A7922 File Offset: 0x001A5B22
		// (set) Token: 0x0600B0A9 RID: 45225 RVA: 0x001A792A File Offset: 0x001A5B2A
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

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x001A7933 File Offset: 0x001A5B33
		// (set) Token: 0x0600B0AB RID: 45227 RVA: 0x001A793B File Offset: 0x001A5B3B
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

		// Token: 0x0600B0AC RID: 45228 RVA: 0x001A7944 File Offset: 0x001A5B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTopInfo);
		}

		// Token: 0x0600B0AD RID: 45229 RVA: 0x001A7952 File Offset: 0x001A5B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTopInfo other)
		{
			return other != null && (other == this || (this.DangerLevel == other.DangerLevel && this.MaxFloor == other.MaxFloor && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0AE RID: 45230 RVA: 0x001A7990 File Offset: 0x001A5B90
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

		// Token: 0x0600B0AF RID: 45231 RVA: 0x001A79E8 File Offset: 0x001A5BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x001A79F5 File Offset: 0x001A5BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0B1 RID: 45233 RVA: 0x001A7A00 File Offset: 0x001A5C00
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

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x001A7A58 File Offset: 0x001A5C58
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

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x001A7AB0 File Offset: 0x001A5CB0
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

		// Token: 0x0600B0B4 RID: 45236 RVA: 0x001A7B00 File Offset: 0x001A5D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x001A7B0C File Offset: 0x001A5D0C
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

		// Token: 0x04004F4F RID: 20303
		private static readonly MessageParser<HonamiStoryTopInfo> _parser = new MessageParser<HonamiStoryTopInfo>(() => new HonamiStoryTopInfo());

		// Token: 0x04004F50 RID: 20304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F51 RID: 20305
		public const int DangerLevelFieldNumber = 1;

		// Token: 0x04004F52 RID: 20306
		private int dangerLevel_;

		// Token: 0x04004F53 RID: 20307
		public const int MaxFloorFieldNumber = 2;

		// Token: 0x04004F54 RID: 20308
		private int maxFloor_;
	}
}
