using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E8 RID: 1000
	[NetMessage(EMessageId.DragonPoolConfRequest)]
	public sealed class DragonPoolConfRequest : IMessage<DragonPoolConfRequest>, IMessage, IEquatable<DragonPoolConfRequest>, IDeepCloneable<DragonPoolConfRequest>, IBufferMessage
	{
		// Token: 0x0600613F RID: 24895 RVA: 0x000EABFB File Offset: 0x000E8DFB
		[NullableContext(1)]
		public static DragonPoolConfRequest Create()
		{
			return new DragonPoolConfRequest();
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06006140 RID: 24896 RVA: 0x000EAC02 File Offset: 0x000E8E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x000EAC05 File Offset: 0x000E8E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolConfRequest.Descriptor;
			}
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x000EAC0C File Offset: 0x000E8E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest()
		{
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x000EAC14 File Offset: 0x000E8E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest(DragonPoolConfRequest other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x000EAC39 File Offset: 0x000E8E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolConfRequest Clone()
		{
			return new DragonPoolConfRequest(this);
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06006145 RID: 24901 RVA: 0x000EAC41 File Offset: 0x000E8E41
		// (set) Token: 0x06006146 RID: 24902 RVA: 0x000EAC49 File Offset: 0x000E8E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x000EAC52 File Offset: 0x000E8E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolConfRequest);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x000EAC60 File Offset: 0x000E8E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolConfRequest other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x000EAC90 File Offset: 0x000E8E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x000EACCF File Offset: 0x000E8ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x000EACDC File Offset: 0x000E8EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x000EACE5 File Offset: 0x000E8EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x000EAD18 File Offset: 0x000E8F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x000EAD56 File Offset: 0x000E8F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DragonPoolConfRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x000EAD87 File Offset: 0x000E8F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x000EAD90 File Offset: 0x000E8F90
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DragonPoolId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037E3 RID: 14307
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037E4 RID: 14308
		public const int DragonPoolIdFieldNumber = 10;

		// Token: 0x040037E5 RID: 14309
		private int dragonPoolId_;
	}
}
