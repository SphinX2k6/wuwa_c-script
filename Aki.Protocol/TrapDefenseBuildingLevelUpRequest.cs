using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001410 RID: 5136
	[NetMessage(EMessageId.TrapDefenseBuildingLevelUpRequest)]
	public sealed class TrapDefenseBuildingLevelUpRequest : IMessage<TrapDefenseBuildingLevelUpRequest>, IMessage, IEquatable<TrapDefenseBuildingLevelUpRequest>, IDeepCloneable<TrapDefenseBuildingLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601B39B RID: 111515 RVA: 0x003F20D8 File Offset: 0x003F02D8
		[NullableContext(1)]
		public static TrapDefenseBuildingLevelUpRequest Create()
		{
			return new TrapDefenseBuildingLevelUpRequest();
		}

		// Token: 0x17005BD5 RID: 23509
		// (get) Token: 0x0601B39C RID: 111516 RVA: 0x003F20DF File Offset: 0x003F02DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BD6 RID: 23510
		// (get) Token: 0x0601B39D RID: 111517 RVA: 0x003F20E2 File Offset: 0x003F02E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601B39E RID: 111518 RVA: 0x003F20E9 File Offset: 0x003F02E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest()
		{
		}

		// Token: 0x0601B39F RID: 111519 RVA: 0x003F20F1 File Offset: 0x003F02F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest(TrapDefenseBuildingLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3A0 RID: 111520 RVA: 0x003F2116 File Offset: 0x003F0316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingLevelUpRequest Clone()
		{
			return new TrapDefenseBuildingLevelUpRequest(this);
		}

		// Token: 0x17005BD7 RID: 23511
		// (get) Token: 0x0601B3A1 RID: 111521 RVA: 0x003F211E File Offset: 0x003F031E
		// (set) Token: 0x0601B3A2 RID: 111522 RVA: 0x003F2126 File Offset: 0x003F0326
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

		// Token: 0x0601B3A3 RID: 111523 RVA: 0x003F212F File Offset: 0x003F032F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingLevelUpRequest);
		}

		// Token: 0x0601B3A4 RID: 111524 RVA: 0x003F213D File Offset: 0x003F033D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3A5 RID: 111525 RVA: 0x003F216C File Offset: 0x003F036C
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

		// Token: 0x0601B3A6 RID: 111526 RVA: 0x003F21AB File Offset: 0x003F03AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3A7 RID: 111527 RVA: 0x003F21B8 File Offset: 0x003F03B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3A8 RID: 111528 RVA: 0x003F21C1 File Offset: 0x003F03C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3A9 RID: 111529 RVA: 0x003F21F4 File Offset: 0x003F03F4
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

		// Token: 0x0601B3AA RID: 111530 RVA: 0x003F2232 File Offset: 0x003F0432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingLevelUpRequest other)
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

		// Token: 0x0601B3AB RID: 111531 RVA: 0x003F2263 File Offset: 0x003F0463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3AC RID: 111532 RVA: 0x003F226C File Offset: 0x003F046C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009D7E RID: 40318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D7F RID: 40319
		public const int IdFieldNumber = 3;

		// Token: 0x04009D80 RID: 40320
		private int id_;
	}
}
