using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3C RID: 3644
	public sealed class RacingBetsChangeHighData : IMessage<RacingBetsChangeHighData>, IMessage, IEquatable<RacingBetsChangeHighData>, IDeepCloneable<RacingBetsChangeHighData>, IBufferMessage
	{
		// Token: 0x06013989 RID: 80265 RVA: 0x002DA0A5 File Offset: 0x002D82A5
		[NullableContext(1)]
		public static RacingBetsChangeHighData Create()
		{
			return new RacingBetsChangeHighData();
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x0601398A RID: 80266 RVA: 0x002DA0AC File Offset: 0x002D82AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsChangeHighData> Parser
		{
			get
			{
				return RacingBetsChangeHighData._parser;
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x0601398B RID: 80267 RVA: 0x002DA0B3 File Offset: 0x002D82B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x0601398C RID: 80268 RVA: 0x002DA0B6 File Offset: 0x002D82B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsChangeHighData.Descriptor;
			}
		}

		// Token: 0x0601398D RID: 80269 RVA: 0x002DA0BD File Offset: 0x002D82BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData()
		{
		}

		// Token: 0x0601398E RID: 80270 RVA: 0x002DA0C5 File Offset: 0x002D82C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData(RacingBetsChangeHighData other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.high_ = other.high_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601398F RID: 80271 RVA: 0x002DA0F6 File Offset: 0x002D82F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsChangeHighData Clone()
		{
			return new RacingBetsChangeHighData(this);
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x06013990 RID: 80272 RVA: 0x002DA0FE File Offset: 0x002D82FE
		// (set) Token: 0x06013991 RID: 80273 RVA: 0x002DA106 File Offset: 0x002D8306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x06013992 RID: 80274 RVA: 0x002DA10F File Offset: 0x002D830F
		// (set) Token: 0x06013993 RID: 80275 RVA: 0x002DA117 File Offset: 0x002D8317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x06013994 RID: 80276 RVA: 0x002DA120 File Offset: 0x002D8320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsChangeHighData);
		}

		// Token: 0x06013995 RID: 80277 RVA: 0x002DA12E File Offset: 0x002D832E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsChangeHighData other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.High == other.High && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013996 RID: 80278 RVA: 0x002DA16C File Offset: 0x002D836C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013997 RID: 80279 RVA: 0x002DA1C4 File Offset: 0x002D83C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013998 RID: 80280 RVA: 0x002DA1D1 File Offset: 0x002D83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013999 RID: 80281 RVA: 0x002DA1DC File Offset: 0x002D83DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.High);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601399A RID: 80282 RVA: 0x002DA234 File Offset: 0x002D8434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601399B RID: 80283 RVA: 0x002DA28C File Offset: 0x002D848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsChangeHighData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601399C RID: 80284 RVA: 0x002DA2DC File Offset: 0x002D84DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601399D RID: 80285 RVA: 0x002DA2E8 File Offset: 0x002D84E8
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
						this.High = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007874 RID: 30836
		private static readonly MessageParser<RacingBetsChangeHighData> _parser = new MessageParser<RacingBetsChangeHighData>(() => new RacingBetsChangeHighData());

		// Token: 0x04007875 RID: 30837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007876 RID: 30838
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007877 RID: 30839
		private int dangoId_;

		// Token: 0x04007878 RID: 30840
		public const int HighFieldNumber = 2;

		// Token: 0x04007879 RID: 30841
		private int high_;
	}
}
