using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001479 RID: 5241
	[NetMessage(EMessageId.TrapDefenseAuxiliaryLevelUpRequest)]
	public sealed class TrapDefenseAuxiliaryLevelUpRequest : IMessage<TrapDefenseAuxiliaryLevelUpRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryLevelUpRequest>, IDeepCloneable<TrapDefenseAuxiliaryLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601BD60 RID: 114016 RVA: 0x0040BB70 File Offset: 0x00409D70
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryLevelUpRequest Create()
		{
			return new TrapDefenseAuxiliaryLevelUpRequest();
		}

		// Token: 0x17005E43 RID: 24131
		// (get) Token: 0x0601BD61 RID: 114017 RVA: 0x0040BB77 File Offset: 0x00409D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E44 RID: 24132
		// (get) Token: 0x0601BD62 RID: 114018 RVA: 0x0040BB7A File Offset: 0x00409D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601BD63 RID: 114019 RVA: 0x0040BB81 File Offset: 0x00409D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest()
		{
		}

		// Token: 0x0601BD64 RID: 114020 RVA: 0x0040BB89 File Offset: 0x00409D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest(TrapDefenseAuxiliaryLevelUpRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD65 RID: 114021 RVA: 0x0040BBAE File Offset: 0x00409DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryLevelUpRequest Clone()
		{
			return new TrapDefenseAuxiliaryLevelUpRequest(this);
		}

		// Token: 0x17005E45 RID: 24133
		// (get) Token: 0x0601BD66 RID: 114022 RVA: 0x0040BBB6 File Offset: 0x00409DB6
		// (set) Token: 0x0601BD67 RID: 114023 RVA: 0x0040BBBE File Offset: 0x00409DBE
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

		// Token: 0x0601BD68 RID: 114024 RVA: 0x0040BBC7 File Offset: 0x00409DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryLevelUpRequest);
		}

		// Token: 0x0601BD69 RID: 114025 RVA: 0x0040BBD5 File Offset: 0x00409DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryLevelUpRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD6A RID: 114026 RVA: 0x0040BC04 File Offset: 0x00409E04
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

		// Token: 0x0601BD6B RID: 114027 RVA: 0x0040BC43 File Offset: 0x00409E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD6C RID: 114028 RVA: 0x0040BC50 File Offset: 0x00409E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD6D RID: 114029 RVA: 0x0040BC59 File Offset: 0x00409E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD6E RID: 114030 RVA: 0x0040BC8C File Offset: 0x00409E8C
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

		// Token: 0x0601BD6F RID: 114031 RVA: 0x0040BCCA File Offset: 0x00409ECA
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

		// Token: 0x0601BD70 RID: 114032 RVA: 0x0040BCFB File Offset: 0x00409EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD71 RID: 114033 RVA: 0x0040BD04 File Offset: 0x00409F04
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A193 RID: 41363
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A194 RID: 41364
		public const int IdFieldNumber = 12;

		// Token: 0x0400A195 RID: 41365
		private int id_;
	}
}
