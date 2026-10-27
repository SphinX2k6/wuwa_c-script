using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001409 RID: 5129
	[NetMessage(EMessageId.TrapDefenseAuxiliaryResetRequest)]
	public sealed class TrapDefenseAuxiliaryResetRequest : IMessage<TrapDefenseAuxiliaryResetRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryResetRequest>, IDeepCloneable<TrapDefenseAuxiliaryResetRequest>, IBufferMessage
	{
		// Token: 0x0601B30B RID: 111371 RVA: 0x003F0E30 File Offset: 0x003EF030
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryResetRequest Create()
		{
			return new TrapDefenseAuxiliaryResetRequest();
		}

		// Token: 0x17005BB7 RID: 23479
		// (get) Token: 0x0601B30C RID: 111372 RVA: 0x003F0E37 File Offset: 0x003EF037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BB8 RID: 23480
		// (get) Token: 0x0601B30D RID: 111373 RVA: 0x003F0E3A File Offset: 0x003EF03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryResetRequest.Descriptor;
			}
		}

		// Token: 0x0601B30E RID: 111374 RVA: 0x003F0E41 File Offset: 0x003EF041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest()
		{
		}

		// Token: 0x0601B30F RID: 111375 RVA: 0x003F0E49 File Offset: 0x003EF049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest(TrapDefenseAuxiliaryResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B310 RID: 111376 RVA: 0x003F0E6E File Offset: 0x003EF06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest Clone()
		{
			return new TrapDefenseAuxiliaryResetRequest(this);
		}

		// Token: 0x17005BB9 RID: 23481
		// (get) Token: 0x0601B311 RID: 111377 RVA: 0x003F0E76 File Offset: 0x003EF076
		// (set) Token: 0x0601B312 RID: 111378 RVA: 0x003F0E7E File Offset: 0x003EF07E
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

		// Token: 0x0601B313 RID: 111379 RVA: 0x003F0E87 File Offset: 0x003EF087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryResetRequest);
		}

		// Token: 0x0601B314 RID: 111380 RVA: 0x003F0E95 File Offset: 0x003EF095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B315 RID: 111381 RVA: 0x003F0EC4 File Offset: 0x003EF0C4
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

		// Token: 0x0601B316 RID: 111382 RVA: 0x003F0F03 File Offset: 0x003EF103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B317 RID: 111383 RVA: 0x003F0F10 File Offset: 0x003EF110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B318 RID: 111384 RVA: 0x003F0F19 File Offset: 0x003EF119
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

		// Token: 0x0601B319 RID: 111385 RVA: 0x003F0F4C File Offset: 0x003EF14C
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

		// Token: 0x0601B31A RID: 111386 RVA: 0x003F0F8A File Offset: 0x003EF18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseAuxiliaryResetRequest other)
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

		// Token: 0x0601B31B RID: 111387 RVA: 0x003F0FBB File Offset: 0x003EF1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B31C RID: 111388 RVA: 0x003F0FC4 File Offset: 0x003EF1C4
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

		// Token: 0x04009D56 RID: 40278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D57 RID: 40279
		public const int IdFieldNumber = 15;

		// Token: 0x04009D58 RID: 40280
		private int id_;
	}
}
