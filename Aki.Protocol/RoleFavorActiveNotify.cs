using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105F RID: 4191
	[NetMessage(EMessageId.RoleFavorActiveNotify)]
	public sealed class RoleFavorActiveNotify : IMessage<RoleFavorActiveNotify>, IMessage, IEquatable<RoleFavorActiveNotify>, IDeepCloneable<RoleFavorActiveNotify>, IBufferMessage
	{
		// Token: 0x060166D4 RID: 91860 RVA: 0x0034366B File Offset: 0x0034186B
		[NullableContext(1)]
		public static RoleFavorActiveNotify Create()
		{
			return new RoleFavorActiveNotify();
		}

		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x060166D5 RID: 91861 RVA: 0x00343672 File Offset: 0x00341872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B1F RID: 19231
		// (get) Token: 0x060166D6 RID: 91862 RVA: 0x00343675 File Offset: 0x00341875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorActiveNotify.Descriptor;
			}
		}

		// Token: 0x060166D7 RID: 91863 RVA: 0x0034367C File Offset: 0x0034187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify()
		{
		}

		// Token: 0x060166D8 RID: 91864 RVA: 0x00343684 File Offset: 0x00341884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify(RoleFavorActiveNotify other) : this()
		{
			this.roleFavorInfo_ = ((other.roleFavorInfo_ != null) ? other.roleFavorInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166D9 RID: 91865 RVA: 0x003436B9 File Offset: 0x003418B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorActiveNotify Clone()
		{
			return new RoleFavorActiveNotify(this);
		}

		// Token: 0x17004B20 RID: 19232
		// (get) Token: 0x060166DA RID: 91866 RVA: 0x003436C1 File Offset: 0x003418C1
		// (set) Token: 0x060166DB RID: 91867 RVA: 0x003436C9 File Offset: 0x003418C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor RoleFavorInfo
		{
			get
			{
				return this.roleFavorInfo_;
			}
			set
			{
				this.roleFavorInfo_ = value;
			}
		}

		// Token: 0x060166DC RID: 91868 RVA: 0x003436D2 File Offset: 0x003418D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorActiveNotify);
		}

		// Token: 0x060166DD RID: 91869 RVA: 0x003436E0 File Offset: 0x003418E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleFavorInfo, other.RoleFavorInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166DE RID: 91870 RVA: 0x00343714 File Offset: 0x00341914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleFavorInfo_ != null)
			{
				num ^= this.RoleFavorInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166DF RID: 91871 RVA: 0x00343750 File Offset: 0x00341950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166E0 RID: 91872 RVA: 0x0034375D File Offset: 0x0034195D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166E1 RID: 91873 RVA: 0x00343766 File Offset: 0x00341966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleFavorInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RoleFavorInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166E2 RID: 91874 RVA: 0x00343798 File Offset: 0x00341998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleFavorInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleFavorInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166E3 RID: 91875 RVA: 0x003437D8 File Offset: 0x003419D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleFavorInfo_ != null)
			{
				if (this.roleFavorInfo_ == null)
				{
					this.RoleFavorInfo = new RoleFavor();
				}
				this.RoleFavorInfo.MergeFrom(other.RoleFavorInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166E4 RID: 91876 RVA: 0x0034382C File Offset: 0x00341A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166E5 RID: 91877 RVA: 0x00343838 File Offset: 0x00341A38
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roleFavorInfo_ == null)
					{
						this.RoleFavorInfo = new RoleFavor();
					}
					input.ReadMessage(this.RoleFavorInfo);
				}
			}
		}

		// Token: 0x040086A8 RID: 34472
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086A9 RID: 34473
		public const int RoleFavorInfoFieldNumber = 12;

		// Token: 0x040086AA RID: 34474
		private RoleFavor roleFavorInfo_;
	}
}
