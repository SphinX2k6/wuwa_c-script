using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001441 RID: 5185
	[NetMessage(EMessageId.TowerStartRequest)]
	public sealed class TowerStartRequest : IMessage<TowerStartRequest>, IMessage, IEquatable<TowerStartRequest>, IDeepCloneable<TowerStartRequest>, IBufferMessage
	{
		// Token: 0x0601B8C8 RID: 112840 RVA: 0x004010A7 File Offset: 0x003FF2A7
		[NullableContext(1)]
		public static TowerStartRequest Create()
		{
			return new TowerStartRequest();
		}

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x0601B8C9 RID: 112841 RVA: 0x004010AE File Offset: 0x003FF2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x0601B8CA RID: 112842 RVA: 0x004010B1 File Offset: 0x003FF2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerStartRequest.Descriptor;
			}
		}

		// Token: 0x0601B8CB RID: 112843 RVA: 0x004010B8 File Offset: 0x003FF2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest()
		{
		}

		// Token: 0x0601B8CC RID: 112844 RVA: 0x004010CB File Offset: 0x003FF2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest(TowerStartRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this.formation_ = other.formation_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8CD RID: 112845 RVA: 0x00401101 File Offset: 0x003FF301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerStartRequest Clone()
		{
			return new TowerStartRequest(this);
		}

		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0601B8CE RID: 112846 RVA: 0x00401109 File Offset: 0x003FF309
		// (set) Token: 0x0601B8CF RID: 112847 RVA: 0x00401111 File Offset: 0x003FF311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005D47 RID: 23879
		// (get) Token: 0x0601B8D0 RID: 112848 RVA: 0x0040111A File Offset: 0x003FF31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRolePb> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x0601B8D1 RID: 112849 RVA: 0x00401122 File Offset: 0x003FF322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerStartRequest);
		}

		// Token: 0x0601B8D2 RID: 112850 RVA: 0x00401130 File Offset: 0x003FF330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerStartRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && this.formation_.Equals(other.formation_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8D3 RID: 112851 RVA: 0x00401180 File Offset: 0x003FF380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			num ^= this.formation_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B8D4 RID: 112852 RVA: 0x004011CD File Offset: 0x003FF3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8D5 RID: 112853 RVA: 0x004011DA File Offset: 0x003FF3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8D6 RID: 112854 RVA: 0x004011E4 File Offset: 0x003FF3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TowerConfigId);
			}
			this.formation_.WriteTo(ref output, TowerStartRequest._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8D7 RID: 112855 RVA: 0x00401234 File Offset: 0x003FF434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			num += this.formation_.CalculateSize(TowerStartRequest._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B8D8 RID: 112856 RVA: 0x00401288 File Offset: 0x003FF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerStartRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this.formation_.Add(other.formation_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8D9 RID: 112857 RVA: 0x004012D5 File Offset: 0x003FF4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8DA RID: 112858 RVA: 0x004012E0 File Offset: 0x003FF4E0
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
				if (num != 56U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formation_.AddEntriesFrom(ref input, TowerStartRequest._repeated_formation_codec);
					}
				}
				else
				{
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A03F RID: 41023
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A040 RID: 41024
		public const int TowerConfigIdFieldNumber = 7;

		// Token: 0x0400A041 RID: 41025
		private int towerConfigId_;

		// Token: 0x0400A042 RID: 41026
		public const int FormationFieldNumber = 12;

		// Token: 0x0400A043 RID: 41027
		private static readonly FieldCodec<TowerRolePb> _repeated_formation_codec = FieldCodec.ForMessage<TowerRolePb>(98U, TowerRolePb.Parser);

		// Token: 0x0400A044 RID: 41028
		private readonly RepeatedField<TowerRolePb> formation_ = new RepeatedField<TowerRolePb>();
	}
}
