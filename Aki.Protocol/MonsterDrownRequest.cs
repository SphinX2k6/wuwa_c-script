using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009EB RID: 2539
	[NetMessage(EMessageId.MonsterDrownRequest)]
	public sealed class MonsterDrownRequest : IMessage<MonsterDrownRequest>, IMessage, IEquatable<MonsterDrownRequest>, IDeepCloneable<MonsterDrownRequest>, IBufferMessage
	{
		// Token: 0x0600DEA8 RID: 57000 RVA: 0x0020AAB0 File Offset: 0x00208CB0
		[NullableContext(1)]
		public static MonsterDrownRequest Create()
		{
			return new MonsterDrownRequest();
		}

		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x0020AAB7 File Offset: 0x00208CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600DEAA RID: 57002 RVA: 0x0020AABA File Offset: 0x00208CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownRequest.Descriptor;
			}
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x0020AAC1 File Offset: 0x00208CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest()
		{
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x0020AAC9 File Offset: 0x00208CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest(MonsterDrownRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x0020AAFE File Offset: 0x00208CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest Clone()
		{
			return new MonsterDrownRequest(this);
		}

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x0020AB06 File Offset: 0x00208D06
		// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x0020AB0E File Offset: 0x00208D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0020AB17 File Offset: 0x00208D17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownRequest);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x0020AB25 File Offset: 0x00208D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x0020AB58 File Offset: 0x00208D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x0020AB94 File Offset: 0x00208D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x0020ABA1 File Offset: 0x00208DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x0020ABAA File Offset: 0x00208DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x0020ABDC File Offset: 0x00208DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x0020AC1C File Offset: 0x00208E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDrownRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x0020AC70 File Offset: 0x00208E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x0020AC7C File Offset: 0x00208E7C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04005C3F RID: 23615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C40 RID: 23616
		public const int PosFieldNumber = 2;

		// Token: 0x04005C41 RID: 23617
		private Vector pos_;
	}
}
