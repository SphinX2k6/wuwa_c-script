using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001406 RID: 5126
	[NetMessage(EMessageId.TrapDefenseAuxiliaryLevelUpRequest)]
	public sealed class TrapDefenseAuxiliaryLevelUpRequest : IMessage<TrapDefenseAuxiliaryLevelUpRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryLevelUpRequest>, IDeepCloneable<TrapDefenseAuxiliaryLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601B2D5 RID: 111317 RVA: 0x003F0898 File Offset: 0x003EEA98
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryLevelUpRequest Create()
		{
			return new TrapDefenseAuxiliaryLevelUpRequest();
		}

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x0601B2D6 RID: 111318 RVA: 0x003F089F File Offset: 0x003EEA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x0601B2D7 RID: 111319 RVA: 0x003F08A2 File Offset: 0x003EEAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601B2D8 RID: 111320 RVA: 0x003F08A9 File Offset: 0x003EEAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest()
		{
		}

		// Token: 0x0601B2D9 RID: 111321 RVA: 0x003F08B1 File Offset: 0x003EEAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest(TrapDefenseAuxiliaryLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B2DA RID: 111322 RVA: 0x003F08D6 File Offset: 0x003EEAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest Clone()
		{
			return new TrapDefenseAuxiliaryLevelUpRequest(this);
		}

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x0601B2DB RID: 111323 RVA: 0x003F08DE File Offset: 0x003EEADE
		// (set) Token: 0x0601B2DC RID: 111324 RVA: 0x003F08E6 File Offset: 0x003EEAE6
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

		// Token: 0x0601B2DD RID: 111325 RVA: 0x003F08EF File Offset: 0x003EEAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryLevelUpRequest);
		}

		// Token: 0x0601B2DE RID: 111326 RVA: 0x003F08FD File Offset: 0x003EEAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B2DF RID: 111327 RVA: 0x003F092C File Offset: 0x003EEB2C
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

		// Token: 0x0601B2E0 RID: 111328 RVA: 0x003F096B File Offset: 0x003EEB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B2E1 RID: 111329 RVA: 0x003F0978 File Offset: 0x003EEB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B2E2 RID: 111330 RVA: 0x003F0981 File Offset: 0x003EEB81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B2E3 RID: 111331 RVA: 0x003F09B4 File Offset: 0x003EEBB4
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

		// Token: 0x0601B2E4 RID: 111332 RVA: 0x003F09F2 File Offset: 0x003EEBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryLevelUpRequest other)
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

		// Token: 0x0601B2E5 RID: 111333 RVA: 0x003F0A23 File Offset: 0x003EEC23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B2E6 RID: 111334 RVA: 0x003F0A2C File Offset: 0x003EEC2C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009D4C RID: 40268
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D4D RID: 40269
		public const int IdFieldNumber = 15;

		// Token: 0x04009D4E RID: 40270
		private int id_;
	}
}
