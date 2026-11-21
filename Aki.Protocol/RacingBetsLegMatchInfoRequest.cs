using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E56 RID: 3670
	[NetMessage(EMessageId.RacingBetsLegMatchInfoRequest)]
	public sealed class RacingBetsLegMatchInfoRequest : IMessage<RacingBetsLegMatchInfoRequest>, IMessage, IEquatable<RacingBetsLegMatchInfoRequest>, IDeepCloneable<RacingBetsLegMatchInfoRequest>, IBufferMessage
	{
		// Token: 0x06013BF6 RID: 80886 RVA: 0x002E0DF5 File Offset: 0x002DEFF5
		[NullableContext(1)]
		public static RacingBetsLegMatchInfoRequest Create()
		{
			return new RacingBetsLegMatchInfoRequest();
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06013BF7 RID: 80887 RVA: 0x002E0DFC File Offset: 0x002DEFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x06013BF8 RID: 80888 RVA: 0x002E0DFF File Offset: 0x002DEFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchInfoRequest.Descriptor;
			}
		}

		// Token: 0x06013BF9 RID: 80889 RVA: 0x002E0E06 File Offset: 0x002DF006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest()
		{
		}

		// Token: 0x06013BFA RID: 80890 RVA: 0x002E0E0E File Offset: 0x002DF00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest(RacingBetsLegMatchInfoRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013BFB RID: 80891 RVA: 0x002E0E3F File Offset: 0x002DF03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoRequest Clone()
		{
			return new RacingBetsLegMatchInfoRequest(this);
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x06013BFC RID: 80892 RVA: 0x002E0E47 File Offset: 0x002DF047
		// (set) Token: 0x06013BFD RID: 80893 RVA: 0x002E0E4F File Offset: 0x002DF04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x06013BFE RID: 80894 RVA: 0x002E0E58 File Offset: 0x002DF058
		// (set) Token: 0x06013BFF RID: 80895 RVA: 0x002E0E60 File Offset: 0x002DF060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x06013C00 RID: 80896 RVA: 0x002E0E69 File Offset: 0x002DF069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchInfoRequest);
		}

		// Token: 0x06013C01 RID: 80897 RVA: 0x002E0E77 File Offset: 0x002DF077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchInfoRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C02 RID: 80898 RVA: 0x002E0EB8 File Offset: 0x002DF0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C03 RID: 80899 RVA: 0x002E0F10 File Offset: 0x002DF110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C04 RID: 80900 RVA: 0x002E0F1D File Offset: 0x002DF11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C05 RID: 80901 RVA: 0x002E0F28 File Offset: 0x002DF128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C06 RID: 80902 RVA: 0x002E0F84 File Offset: 0x002DF184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C07 RID: 80903 RVA: 0x002E0FDC File Offset: 0x002DF1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsLegMatchInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C08 RID: 80904 RVA: 0x002E102C File Offset: 0x002DF22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C09 RID: 80905 RVA: 0x002E1038 File Offset: 0x002DF238
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
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007956 RID: 31062
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007957 RID: 31063
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04007958 RID: 31064
		private int activityId_;

		// Token: 0x04007959 RID: 31065
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x0400795A RID: 31066
		private int legMatchId_;
	}
}
