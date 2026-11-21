using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CC RID: 2252
	public sealed class KurotatoWeaponEntityPbData : IMessage<KurotatoWeaponEntityPbData>, IMessage, IEquatable<KurotatoWeaponEntityPbData>, IDeepCloneable<KurotatoWeaponEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C7C0 RID: 51136 RVA: 0x001D8D9E File Offset: 0x001D6F9E
		[NullableContext(1)]
		public static KurotatoWeaponEntityPbData Create()
		{
			return new KurotatoWeaponEntityPbData();
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600C7C1 RID: 51137 RVA: 0x001D8DA5 File Offset: 0x001D6FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x0600C7C2 RID: 51138 RVA: 0x001D8DA8 File Offset: 0x001D6FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoWeaponEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C7C3 RID: 51139 RVA: 0x001D8DAF File Offset: 0x001D6FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData()
		{
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x001D8DB7 File Offset: 0x001D6FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData(KurotatoWeaponEntityPbData other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7C5 RID: 51141 RVA: 0x001D8DDC File Offset: 0x001D6FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponEntityPbData Clone()
		{
			return new KurotatoWeaponEntityPbData(this);
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600C7C6 RID: 51142 RVA: 0x001D8DE4 File Offset: 0x001D6FE4
		// (set) Token: 0x0600C7C7 RID: 51143 RVA: 0x001D8DEC File Offset: 0x001D6FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600C7C8 RID: 51144 RVA: 0x001D8DF5 File Offset: 0x001D6FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoWeaponEntityPbData);
		}

		// Token: 0x0600C7C9 RID: 51145 RVA: 0x001D8E03 File Offset: 0x001D7003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoWeaponEntityPbData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7CA RID: 51146 RVA: 0x001D8E34 File Offset: 0x001D7034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7CB RID: 51147 RVA: 0x001D8E73 File Offset: 0x001D7073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7CC RID: 51148 RVA: 0x001D8E80 File Offset: 0x001D7080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7CD RID: 51149 RVA: 0x001D8E89 File Offset: 0x001D7089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7CE RID: 51150 RVA: 0x001D8EBC File Offset: 0x001D70BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7CF RID: 51151 RVA: 0x001D8EFA File Offset: 0x001D70FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoWeaponEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x001D8F2B File Offset: 0x001D712B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x001D8F34 File Offset: 0x001D7134
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055D3 RID: 21971
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055D4 RID: 21972
		public const int IncIdFieldNumber = 1;

		// Token: 0x040055D5 RID: 21973
		private int incId_;
	}
}
