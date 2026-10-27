using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078D RID: 1933
	public sealed class HonamiStoryMascotInfo : IMessage<HonamiStoryMascotInfo>, IMessage, IEquatable<HonamiStoryMascotInfo>, IDeepCloneable<HonamiStoryMascotInfo>, IBufferMessage
	{
		// Token: 0x0600AE8D RID: 44685 RVA: 0x001A3639 File Offset: 0x001A1839
		[NullableContext(1)]
		public static HonamiStoryMascotInfo Create()
		{
			return new HonamiStoryMascotInfo();
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600AE8E RID: 44686 RVA: 0x001A3640 File Offset: 0x001A1840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryMascotInfo> Parser
		{
			get
			{
				return HonamiStoryMascotInfo._parser;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600AE8F RID: 44687 RVA: 0x001A3647 File Offset: 0x001A1847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x0600AE90 RID: 44688 RVA: 0x001A364A File Offset: 0x001A184A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotInfo.Descriptor;
			}
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x001A3651 File Offset: 0x001A1851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo()
		{
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x001A3659 File Offset: 0x001A1859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo(HonamiStoryMascotInfo other) : this()
		{
			this.honamiStoryMascotId_ = other.honamiStoryMascotId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x001A368A File Offset: 0x001A188A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotInfo Clone()
		{
			return new HonamiStoryMascotInfo(this);
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0600AE94 RID: 44692 RVA: 0x001A3692 File Offset: 0x001A1892
		// (set) Token: 0x0600AE95 RID: 44693 RVA: 0x001A369A File Offset: 0x001A189A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryMascotId
		{
			get
			{
				return this.honamiStoryMascotId_;
			}
			set
			{
				this.honamiStoryMascotId_ = value;
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600AE96 RID: 44694 RVA: 0x001A36A3 File Offset: 0x001A18A3
		// (set) Token: 0x0600AE97 RID: 44695 RVA: 0x001A36AB File Offset: 0x001A18AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600AE98 RID: 44696 RVA: 0x001A36B4 File Offset: 0x001A18B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotInfo);
		}

		// Token: 0x0600AE99 RID: 44697 RVA: 0x001A36C2 File Offset: 0x001A18C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryMascotId == other.HonamiStoryMascotId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE9A RID: 44698 RVA: 0x001A3700 File Offset: 0x001A1900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryMascotId != 0)
			{
				num ^= this.HonamiStoryMascotId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE9B RID: 44699 RVA: 0x001A3758 File Offset: 0x001A1958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE9C RID: 44700 RVA: 0x001A3765 File Offset: 0x001A1965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE9D RID: 44701 RVA: 0x001A3770 File Offset: 0x001A1970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryMascotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HonamiStoryMascotId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE9E RID: 44702 RVA: 0x001A37C8 File Offset: 0x001A19C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryMascotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryMascotId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE9F RID: 44703 RVA: 0x001A3820 File Offset: 0x001A1A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryMascotId != 0)
			{
				this.HonamiStoryMascotId = other.HonamiStoryMascotId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x001A3870 File Offset: 0x001A1A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x001A387C File Offset: 0x001A1A7C
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
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.HonamiStoryMascotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EC5 RID: 20165
		private static readonly MessageParser<HonamiStoryMascotInfo> _parser = new MessageParser<HonamiStoryMascotInfo>(() => new HonamiStoryMascotInfo());

		// Token: 0x04004EC6 RID: 20166
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC7 RID: 20167
		public const int HonamiStoryMascotIdFieldNumber = 1;

		// Token: 0x04004EC8 RID: 20168
		private int honamiStoryMascotId_;

		// Token: 0x04004EC9 RID: 20169
		public const int StatusFieldNumber = 2;

		// Token: 0x04004ECA RID: 20170
		private int status_;
	}
}
