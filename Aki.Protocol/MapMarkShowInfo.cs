using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098F RID: 2447
	public sealed class MapMarkShowInfo : IMessage<MapMarkShowInfo>, IMessage, IEquatable<MapMarkShowInfo>, IDeepCloneable<MapMarkShowInfo>, IBufferMessage
	{
		// Token: 0x0600D716 RID: 55062 RVA: 0x001FA279 File Offset: 0x001F8479
		[NullableContext(1)]
		public static MapMarkShowInfo Create()
		{
			return new MapMarkShowInfo();
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0600D717 RID: 55063 RVA: 0x001FA280 File Offset: 0x001F8480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapMarkShowInfo> Parser
		{
			get
			{
				return MapMarkShowInfo._parser;
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600D718 RID: 55064 RVA: 0x001FA287 File Offset: 0x001F8487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x001FA28A File Offset: 0x001F848A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkShowInfo.Descriptor;
			}
		}

		// Token: 0x0600D71A RID: 55066 RVA: 0x001FA291 File Offset: 0x001F8491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo()
		{
		}

		// Token: 0x0600D71B RID: 55067 RVA: 0x001FA299 File Offset: 0x001F8499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo(MapMarkShowInfo other) : this()
		{
			this.markId_ = other.markId_;
			this.showFlag_ = other.showFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x001FA2CA File Offset: 0x001F84CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo Clone()
		{
			return new MapMarkShowInfo(this);
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x0600D71D RID: 55069 RVA: 0x001FA2D2 File Offset: 0x001F84D2
		// (set) Token: 0x0600D71E RID: 55070 RVA: 0x001FA2DA File Offset: 0x001F84DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x0600D71F RID: 55071 RVA: 0x001FA2E3 File Offset: 0x001F84E3
		// (set) Token: 0x0600D720 RID: 55072 RVA: 0x001FA2EB File Offset: 0x001F84EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShowFlag
		{
			get
			{
				return this.showFlag_;
			}
			set
			{
				this.showFlag_ = value;
			}
		}

		// Token: 0x0600D721 RID: 55073 RVA: 0x001FA2F4 File Offset: 0x001F84F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkShowInfo);
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x001FA302 File Offset: 0x001F8502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkShowInfo other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.ShowFlag == other.ShowFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x001FA340 File Offset: 0x001F8540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.ShowFlag != 0U)
			{
				num ^= this.ShowFlag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x001FA398 File Offset: 0x001F8598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D725 RID: 55077 RVA: 0x001FA3A5 File Offset: 0x001F85A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x001FA3B0 File Offset: 0x001F85B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkId);
			}
			if (this.ShowFlag != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.ShowFlag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x001FA408 File Offset: 0x001F8608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.ShowFlag != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShowFlag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D728 RID: 55080 RVA: 0x001FA460 File Offset: 0x001F8660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkShowInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.ShowFlag != 0U)
			{
				this.ShowFlag = other.ShowFlag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x001FA4B0 File Offset: 0x001F86B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x001FA4BC File Offset: 0x001F86BC
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
						this.ShowFlag = input.ReadUInt32();
					}
				}
				else
				{
					this.MarkId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040059D6 RID: 22998
		private static readonly MessageParser<MapMarkShowInfo> _parser = new MessageParser<MapMarkShowInfo>(() => new MapMarkShowInfo());

		// Token: 0x040059D7 RID: 22999
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059D8 RID: 23000
		public const int MarkIdFieldNumber = 1;

		// Token: 0x040059D9 RID: 23001
		private int markId_;

		// Token: 0x040059DA RID: 23002
		public const int ShowFlagFieldNumber = 2;

		// Token: 0x040059DB RID: 23003
		private uint showFlag_;
	}
}
