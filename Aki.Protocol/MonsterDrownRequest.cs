using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FC RID: 2556
	[NetMessage(EMessageId.MonsterDrownRequest)]
	public sealed class MonsterDrownRequest : IMessage<MonsterDrownRequest>, IMessage, IEquatable<MonsterDrownRequest>, IDeepCloneable<MonsterDrownRequest>, IBufferMessage
	{
		// Token: 0x0600DFC2 RID: 57282 RVA: 0x0020CC9C File Offset: 0x0020AE9C
		[NullableContext(1)]
		public static MonsterDrownRequest Create()
		{
			return new MonsterDrownRequest();
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600DFC3 RID: 57283 RVA: 0x0020CCA3 File Offset: 0x0020AEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x0020CCA6 File Offset: 0x0020AEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownRequest.Descriptor;
			}
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x0020CCAD File Offset: 0x0020AEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest()
		{
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x0020CCB5 File Offset: 0x0020AEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest(MonsterDrownRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x0020CCEA File Offset: 0x0020AEEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownRequest Clone()
		{
			return new MonsterDrownRequest(this);
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600DFC8 RID: 57288 RVA: 0x0020CCF2 File Offset: 0x0020AEF2
		// (set) Token: 0x0600DFC9 RID: 57289 RVA: 0x0020CCFA File Offset: 0x0020AEFA
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

		// Token: 0x0600DFCA RID: 57290 RVA: 0x0020CD03 File Offset: 0x0020AF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownRequest);
		}

		// Token: 0x0600DFCB RID: 57291 RVA: 0x0020CD11 File Offset: 0x0020AF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x0020CD44 File Offset: 0x0020AF44
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

		// Token: 0x0600DFCD RID: 57293 RVA: 0x0020CD80 File Offset: 0x0020AF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x0020CD8D File Offset: 0x0020AF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x0020CD96 File Offset: 0x0020AF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x0020CDC8 File Offset: 0x0020AFC8
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

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x0020CE08 File Offset: 0x0020B008
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

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x0020CE5C File Offset: 0x0020B05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x0020CE68 File Offset: 0x0020B068
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
				if (num != 82U)
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

		// Token: 0x04005C36 RID: 23606
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C37 RID: 23607
		public const int PosFieldNumber = 10;

		// Token: 0x04005C38 RID: 23608
		private Vector pos_;
	}
}
