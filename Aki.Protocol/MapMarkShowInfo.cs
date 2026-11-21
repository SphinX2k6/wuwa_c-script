using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097E RID: 2430
	public sealed class MapMarkShowInfo : IMessage<MapMarkShowInfo>, IMessage, IEquatable<MapMarkShowInfo>, IDeepCloneable<MapMarkShowInfo>, IBufferMessage
	{
		// Token: 0x0600D5FC RID: 54780 RVA: 0x001F8088 File Offset: 0x001F6288
		[NullableContext(1)]
		public static MapMarkShowInfo Create()
		{
			return new MapMarkShowInfo();
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x001F808F File Offset: 0x001F628F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapMarkShowInfo> Parser
		{
			get
			{
				return MapMarkShowInfo._parser;
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600D5FE RID: 54782 RVA: 0x001F8096 File Offset: 0x001F6296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x001F8099 File Offset: 0x001F6299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkShowInfo.Descriptor;
			}
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x001F80A0 File Offset: 0x001F62A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo()
		{
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x001F80A8 File Offset: 0x001F62A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo(MapMarkShowInfo other) : this()
		{
			this.markId_ = other.markId_;
			this.showFlag_ = other.showFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D602 RID: 54786 RVA: 0x001F80D9 File Offset: 0x001F62D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowInfo Clone()
		{
			return new MapMarkShowInfo(this);
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600D603 RID: 54787 RVA: 0x001F80E1 File Offset: 0x001F62E1
		// (set) Token: 0x0600D604 RID: 54788 RVA: 0x001F80E9 File Offset: 0x001F62E9
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

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600D605 RID: 54789 RVA: 0x001F80F2 File Offset: 0x001F62F2
		// (set) Token: 0x0600D606 RID: 54790 RVA: 0x001F80FA File Offset: 0x001F62FA
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

		// Token: 0x0600D607 RID: 54791 RVA: 0x001F8103 File Offset: 0x001F6303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkShowInfo);
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x001F8111 File Offset: 0x001F6311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkShowInfo other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.ShowFlag == other.ShowFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x001F8150 File Offset: 0x001F6350
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

		// Token: 0x0600D60A RID: 54794 RVA: 0x001F81A8 File Offset: 0x001F63A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D60B RID: 54795 RVA: 0x001F81B5 File Offset: 0x001F63B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x001F81C0 File Offset: 0x001F63C0
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

		// Token: 0x0600D60D RID: 54797 RVA: 0x001F8218 File Offset: 0x001F6418
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

		// Token: 0x0600D60E RID: 54798 RVA: 0x001F8270 File Offset: 0x001F6470
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

		// Token: 0x0600D60F RID: 54799 RVA: 0x001F82C0 File Offset: 0x001F64C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x001F82CC File Offset: 0x001F64CC
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

		// Token: 0x040059DF RID: 23007
		private static readonly MessageParser<MapMarkShowInfo> _parser = new MessageParser<MapMarkShowInfo>(() => new MapMarkShowInfo());

		// Token: 0x040059E0 RID: 23008
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059E1 RID: 23009
		public const int MarkIdFieldNumber = 1;

		// Token: 0x040059E2 RID: 23010
		private int markId_;

		// Token: 0x040059E3 RID: 23011
		public const int ShowFlagFieldNumber = 2;

		// Token: 0x040059E4 RID: 23012
		private uint showFlag_;
	}
}
