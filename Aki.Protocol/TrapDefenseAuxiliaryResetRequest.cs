using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147C RID: 5244
	[NetMessage(EMessageId.TrapDefenseAuxiliaryResetRequest)]
	public sealed class TrapDefenseAuxiliaryResetRequest : IMessage<TrapDefenseAuxiliaryResetRequest>, IMessage, IEquatable<TrapDefenseAuxiliaryResetRequest>, IDeepCloneable<TrapDefenseAuxiliaryResetRequest>, IBufferMessage
	{
		// Token: 0x0601BD96 RID: 114070 RVA: 0x0040C104 File Offset: 0x0040A304
		[NullableContext(1)]
		public static TrapDefenseAuxiliaryResetRequest Create()
		{
			return new TrapDefenseAuxiliaryResetRequest();
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x0601BD97 RID: 114071 RVA: 0x0040C10B File Offset: 0x0040A30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x0601BD98 RID: 114072 RVA: 0x0040C10E File Offset: 0x0040A30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseAuxiliaryResetRequest.Descriptor;
			}
		}

		// Token: 0x0601BD99 RID: 114073 RVA: 0x0040C115 File Offset: 0x0040A315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest()
		{
		}

		// Token: 0x0601BD9A RID: 114074 RVA: 0x0040C11D File Offset: 0x0040A31D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest(TrapDefenseAuxiliaryResetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD9B RID: 114075 RVA: 0x0040C142 File Offset: 0x0040A342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryResetRequest Clone()
		{
			return new TrapDefenseAuxiliaryResetRequest(this);
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x0601BD9C RID: 114076 RVA: 0x0040C14A File Offset: 0x0040A34A
		// (set) Token: 0x0601BD9D RID: 114077 RVA: 0x0040C152 File Offset: 0x0040A352
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

		// Token: 0x0601BD9E RID: 114078 RVA: 0x0040C15B File Offset: 0x0040A35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseAuxiliaryResetRequest);
		}

		// Token: 0x0601BD9F RID: 114079 RVA: 0x0040C169 File Offset: 0x0040A369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseAuxiliaryResetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BDA0 RID: 114080 RVA: 0x0040C198 File Offset: 0x0040A398
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

		// Token: 0x0601BDA1 RID: 114081 RVA: 0x0040C1D7 File Offset: 0x0040A3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BDA2 RID: 114082 RVA: 0x0040C1E4 File Offset: 0x0040A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BDA3 RID: 114083 RVA: 0x0040C1ED File Offset: 0x0040A3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BDA4 RID: 114084 RVA: 0x0040C220 File Offset: 0x0040A420
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

		// Token: 0x0601BDA5 RID: 114085 RVA: 0x0040C25E File Offset: 0x0040A45E
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

		// Token: 0x0601BDA6 RID: 114086 RVA: 0x0040C28F File Offset: 0x0040A48F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BDA7 RID: 114087 RVA: 0x0040C298 File Offset: 0x0040A498
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A19D RID: 41373
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A19E RID: 41374
		public const int IdFieldNumber = 2;

		// Token: 0x0400A19F RID: 41375
		private int id_;
	}
}
