using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E56 RID: 3670
	public sealed class RacingBetsDangoInfo : IMessage<RacingBetsDangoInfo>, IMessage, IEquatable<RacingBetsDangoInfo>, IDeepCloneable<RacingBetsDangoInfo>, IBufferMessage
	{
		// Token: 0x06013B38 RID: 80696 RVA: 0x002DD15C File Offset: 0x002DB35C
		[NullableContext(1)]
		public static RacingBetsDangoInfo Create()
		{
			return new RacingBetsDangoInfo();
		}

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06013B39 RID: 80697 RVA: 0x002DD163 File Offset: 0x002DB363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsDangoInfo> Parser
		{
			get
			{
				return RacingBetsDangoInfo._parser;
			}
		}

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06013B3A RID: 80698 RVA: 0x002DD16A File Offset: 0x002DB36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06013B3B RID: 80699 RVA: 0x002DD16D File Offset: 0x002DB36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoInfo.Descriptor;
			}
		}

		// Token: 0x06013B3C RID: 80700 RVA: 0x002DD174 File Offset: 0x002DB374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo()
		{
		}

		// Token: 0x06013B3D RID: 80701 RVA: 0x002DD17C File Offset: 0x002DB37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo(RacingBetsDangoInfo other) : this()
		{
			this.id_ = other.id_;
			this.curPoint_ = other.curPoint_;
			this.odds_ = other.odds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B3E RID: 80702 RVA: 0x002DD1B9 File Offset: 0x002DB3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo Clone()
		{
			return new RacingBetsDangoInfo(this);
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06013B3F RID: 80703 RVA: 0x002DD1C1 File Offset: 0x002DB3C1
		// (set) Token: 0x06013B40 RID: 80704 RVA: 0x002DD1C9 File Offset: 0x002DB3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004165 RID: 16741
		// (get) Token: 0x06013B41 RID: 80705 RVA: 0x002DD1D2 File Offset: 0x002DB3D2
		// (set) Token: 0x06013B42 RID: 80706 RVA: 0x002DD1DA File Offset: 0x002DB3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x17004166 RID: 16742
		// (get) Token: 0x06013B43 RID: 80707 RVA: 0x002DD1E3 File Offset: 0x002DB3E3
		// (set) Token: 0x06013B44 RID: 80708 RVA: 0x002DD1EB File Offset: 0x002DB3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Odds
		{
			get
			{
				return this.odds_;
			}
			set
			{
				this.odds_ = value;
			}
		}

		// Token: 0x06013B45 RID: 80709 RVA: 0x002DD1F4 File Offset: 0x002DB3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoInfo);
		}

		// Token: 0x06013B46 RID: 80710 RVA: 0x002DD204 File Offset: 0x002DB404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CurPoint == other.CurPoint && this.Odds == other.Odds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B47 RID: 80711 RVA: 0x002DD260 File Offset: 0x002DB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.Odds != 0)
			{
				num ^= this.Odds.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B48 RID: 80712 RVA: 0x002DD2D1 File Offset: 0x002DB4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B49 RID: 80713 RVA: 0x002DD2DE File Offset: 0x002DB4DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B4A RID: 80714 RVA: 0x002DD2E8 File Offset: 0x002DB4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurPoint);
			}
			if (this.Odds != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Odds);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B4B RID: 80715 RVA: 0x002DD35C File Offset: 0x002DB55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.Odds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Odds);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B4C RID: 80716 RVA: 0x002DD3CC File Offset: 0x002DB5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.Odds != 0)
			{
				this.Odds = other.Odds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B4D RID: 80717 RVA: 0x002DD430 File Offset: 0x002DB630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B4E RID: 80718 RVA: 0x002DD43C File Offset: 0x002DB63C
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
							this.Odds = input.ReadInt32();
						}
					}
					else
					{
						this.CurPoint = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007882 RID: 30850
		private static readonly MessageParser<RacingBetsDangoInfo> _parser = new MessageParser<RacingBetsDangoInfo>(() => new RacingBetsDangoInfo());

		// Token: 0x04007883 RID: 30851
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007884 RID: 30852
		public const int IdFieldNumber = 1;

		// Token: 0x04007885 RID: 30853
		private int id_;

		// Token: 0x04007886 RID: 30854
		public const int CurPointFieldNumber = 2;

		// Token: 0x04007887 RID: 30855
		private int curPoint_;

		// Token: 0x04007888 RID: 30856
		public const int OddsFieldNumber = 3;

		// Token: 0x04007889 RID: 30857
		private int odds_;
	}
}
