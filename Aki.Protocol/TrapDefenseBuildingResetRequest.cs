using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001413 RID: 5139
	[NetMessage(EMessageId.TrapDefenseBuildingResetRequest)]
	public sealed class TrapDefenseBuildingResetRequest : IMessage<TrapDefenseBuildingResetRequest>, IMessage, IEquatable<TrapDefenseBuildingResetRequest>, IDeepCloneable<TrapDefenseBuildingResetRequest>, IBufferMessage
	{
		// Token: 0x0601B3D7 RID: 111575 RVA: 0x003F2888 File Offset: 0x003F0A88
		[NullableContext(1)]
		public static TrapDefenseBuildingResetRequest Create()
		{
			return new TrapDefenseBuildingResetRequest();
		}

		// Token: 0x17005BE1 RID: 23521
		// (get) Token: 0x0601B3D8 RID: 111576 RVA: 0x003F288F File Offset: 0x003F0A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BE2 RID: 23522
		// (get) Token: 0x0601B3D9 RID: 111577 RVA: 0x003F2892 File Offset: 0x003F0A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingResetRequest.Descriptor;
			}
		}

		// Token: 0x0601B3DA RID: 111578 RVA: 0x003F2899 File Offset: 0x003F0A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest()
		{
		}

		// Token: 0x0601B3DB RID: 111579 RVA: 0x003F28A1 File Offset: 0x003F0AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest(TrapDefenseBuildingResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3DC RID: 111580 RVA: 0x003F28C6 File Offset: 0x003F0AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingResetRequest Clone()
		{
			return new TrapDefenseBuildingResetRequest(this);
		}

		// Token: 0x17005BE3 RID: 23523
		// (get) Token: 0x0601B3DD RID: 111581 RVA: 0x003F28CE File Offset: 0x003F0ACE
		// (set) Token: 0x0601B3DE RID: 111582 RVA: 0x003F28D6 File Offset: 0x003F0AD6
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

		// Token: 0x0601B3DF RID: 111583 RVA: 0x003F28DF File Offset: 0x003F0ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingResetRequest);
		}

		// Token: 0x0601B3E0 RID: 111584 RVA: 0x003F28ED File Offset: 0x003F0AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x003F291C File Offset: 0x003F0B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3E2 RID: 111586 RVA: 0x003F295B File Offset: 0x003F0B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3E3 RID: 111587 RVA: 0x003F2968 File Offset: 0x003F0B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3E4 RID: 111588 RVA: 0x003F2971 File Offset: 0x003F0B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3E5 RID: 111589 RVA: 0x003F29A4 File Offset: 0x003F0BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3E6 RID: 111590 RVA: 0x003F29E2 File Offset: 0x003F0BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingResetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3E7 RID: 111591 RVA: 0x003F2A13 File Offset: 0x003F0C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3E8 RID: 111592 RVA: 0x003F2A1C File Offset: 0x003F0C1C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009D8D RID: 40333
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D8E RID: 40334
		public const int IdFieldNumber = 9;

		// Token: 0x04009D8F RID: 40335
		private int id_;
	}
}
