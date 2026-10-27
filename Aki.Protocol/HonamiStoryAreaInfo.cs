using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000762 RID: 1890
	public sealed class HonamiStoryAreaInfo : IMessage<HonamiStoryAreaInfo>, IMessage, IEquatable<HonamiStoryAreaInfo>, IDeepCloneable<HonamiStoryAreaInfo>, IBufferMessage
	{
		// Token: 0x0600AB0F RID: 43791 RVA: 0x0019BC35 File Offset: 0x00199E35
		[NullableContext(1)]
		public static HonamiStoryAreaInfo Create()
		{
			return new HonamiStoryAreaInfo();
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x0019BC3C File Offset: 0x00199E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryAreaInfo> Parser
		{
			get
			{
				return HonamiStoryAreaInfo._parser;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600AB11 RID: 43793 RVA: 0x0019BC43 File Offset: 0x00199E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x0019BC46 File Offset: 0x00199E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x0019BC4D File Offset: 0x00199E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo()
		{
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x0019BC55 File Offset: 0x00199E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo(HonamiStoryAreaInfo other) : this()
		{
			this.honamiStoryAreaId_ = other.honamiStoryAreaId_;
			this.status_ = other.status_;
			this.secreteStatus_ = other.secreteStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x0019BC92 File Offset: 0x00199E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo Clone()
		{
			return new HonamiStoryAreaInfo(this);
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x0019BC9A File Offset: 0x00199E9A
		// (set) Token: 0x0600AB17 RID: 43799 RVA: 0x0019BCA2 File Offset: 0x00199EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryAreaId
		{
			get
			{
				return this.honamiStoryAreaId_;
			}
			set
			{
				this.honamiStoryAreaId_ = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x0019BCAB File Offset: 0x00199EAB
		// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x0019BCB3 File Offset: 0x00199EB3
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

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x0019BCBC File Offset: 0x00199EBC
		// (set) Token: 0x0600AB1B RID: 43803 RVA: 0x0019BCC4 File Offset: 0x00199EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecreteStatus
		{
			get
			{
				return this.secreteStatus_;
			}
			set
			{
				this.secreteStatus_ = value;
			}
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x0019BCCD File Offset: 0x00199ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaInfo);
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x0019BCDC File Offset: 0x00199EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryAreaId == other.HonamiStoryAreaId && this.Status == other.Status && this.SecreteStatus == other.SecreteStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x0019BD38 File Offset: 0x00199F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryAreaId != 0)
			{
				num ^= this.HonamiStoryAreaId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.SecreteStatus != 0)
			{
				num ^= this.SecreteStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x0019BDA9 File Offset: 0x00199FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x0019BDB6 File Offset: 0x00199FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x0019BDC0 File Offset: 0x00199FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryAreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HonamiStoryAreaId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this.SecreteStatus != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SecreteStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x0019BE34 File Offset: 0x0019A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryAreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryAreaId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.SecreteStatus != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecreteStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x0019BEA4 File Offset: 0x0019A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryAreaId != 0)
			{
				this.HonamiStoryAreaId = other.HonamiStoryAreaId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.SecreteStatus != 0)
			{
				this.SecreteStatus = other.SecreteStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x0019BF08 File Offset: 0x0019A108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x0019BF14 File Offset: 0x0019A114
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SecreteStatus = input.ReadInt32();
						}
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.HonamiStoryAreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DBD RID: 19901
		private static readonly MessageParser<HonamiStoryAreaInfo> _parser = new MessageParser<HonamiStoryAreaInfo>(() => new HonamiStoryAreaInfo());

		// Token: 0x04004DBE RID: 19902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBF RID: 19903
		public const int HonamiStoryAreaIdFieldNumber = 1;

		// Token: 0x04004DC0 RID: 19904
		private int honamiStoryAreaId_;

		// Token: 0x04004DC1 RID: 19905
		public const int StatusFieldNumber = 2;

		// Token: 0x04004DC2 RID: 19906
		private int status_;

		// Token: 0x04004DC3 RID: 19907
		public const int SecreteStatusFieldNumber = 3;

		// Token: 0x04004DC4 RID: 19908
		private int secreteStatus_;
	}
}
