using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044C RID: 1100
	[NetMessage(EMessageId.EnterAreaNotify)]
	public sealed class EnterAreaNotify : IMessage<EnterAreaNotify>, IMessage, IEquatable<EnterAreaNotify>, IDeepCloneable<EnterAreaNotify>, IBufferMessage
	{
		// Token: 0x0600691B RID: 26907 RVA: 0x000FC345 File Offset: 0x000FA545
		[NullableContext(1)]
		public static EnterAreaNotify Create()
		{
			return new EnterAreaNotify();
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x000FC34C File Offset: 0x000FA54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600691D RID: 26909 RVA: 0x000FC34F File Offset: 0x000FA54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAreaNotify.Descriptor;
			}
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x000FC356 File Offset: 0x000FA556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify()
		{
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x000FC35E File Offset: 0x000FA55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify(EnterAreaNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x000FC38F File Offset: 0x000FA58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAreaNotify Clone()
		{
			return new EnterAreaNotify(this);
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x06006921 RID: 26913 RVA: 0x000FC397 File Offset: 0x000FA597
		// (set) Token: 0x06006922 RID: 26914 RVA: 0x000FC39F File Offset: 0x000FA59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x06006923 RID: 26915 RVA: 0x000FC3A8 File Offset: 0x000FA5A8
		// (set) Token: 0x06006924 RID: 26916 RVA: 0x000FC3B0 File Offset: 0x000FA5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x000FC3B9 File Offset: 0x000FA5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAreaNotify);
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x000FC3C7 File Offset: 0x000FA5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAreaNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x000FC408 File Offset: 0x000FA608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x000FC460 File Offset: 0x000FA660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x000FC46D File Offset: 0x000FA66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x000FC478 File Offset: 0x000FA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.AreaId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x000FC4D4 File Offset: 0x000FA6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x000FC52C File Offset: 0x000FA72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAreaNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x000FC57C File Offset: 0x000FA77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x000FC588 File Offset: 0x000FA788
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039E0 RID: 14816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E1 RID: 14817
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x040039E2 RID: 14818
		private int playerId_;

		// Token: 0x040039E3 RID: 14819
		public const int AreaIdFieldNumber = 11;

		// Token: 0x040039E4 RID: 14820
		private int areaId_;
	}
}
