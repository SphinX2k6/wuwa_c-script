using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200128E RID: 4750
	[NetMessage(EMessageId.StartRecallRequest)]
	public sealed class StartRecallRequest : IMessage<StartRecallRequest>, IMessage, IEquatable<StartRecallRequest>, IDeepCloneable<StartRecallRequest>, IBufferMessage
	{
		// Token: 0x060194AC RID: 103596 RVA: 0x003AD8D9 File Offset: 0x003ABAD9
		[NullableContext(1)]
		public static StartRecallRequest Create()
		{
			return new StartRecallRequest();
		}

		// Token: 0x17005550 RID: 21840
		// (get) Token: 0x060194AD RID: 103597 RVA: 0x003AD8E0 File Offset: 0x003ABAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005551 RID: 21841
		// (get) Token: 0x060194AE RID: 103598 RVA: 0x003AD8E3 File Offset: 0x003ABAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRecallRequest.Descriptor;
			}
		}

		// Token: 0x060194AF RID: 103599 RVA: 0x003AD8EA File Offset: 0x003ABAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest()
		{
		}

		// Token: 0x060194B0 RID: 103600 RVA: 0x003AD8F2 File Offset: 0x003ABAF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest(StartRecallRequest other) : this()
		{
			this.recallId_ = other.recallId_;
			this.continue_ = other.continue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194B1 RID: 103601 RVA: 0x003AD923 File Offset: 0x003ABB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest Clone()
		{
			return new StartRecallRequest(this);
		}

		// Token: 0x17005552 RID: 21842
		// (get) Token: 0x060194B2 RID: 103602 RVA: 0x003AD92B File Offset: 0x003ABB2B
		// (set) Token: 0x060194B3 RID: 103603 RVA: 0x003AD933 File Offset: 0x003ABB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x060194B4 RID: 103604 RVA: 0x003AD93C File Offset: 0x003ABB3C
		// (set) Token: 0x060194B5 RID: 103605 RVA: 0x003AD944 File Offset: 0x003ABB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x060194B6 RID: 103606 RVA: 0x003AD94D File Offset: 0x003ABB4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRecallRequest);
		}

		// Token: 0x060194B7 RID: 103607 RVA: 0x003AD95B File Offset: 0x003ABB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRecallRequest other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.Continue == other.Continue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194B8 RID: 103608 RVA: 0x003AD99C File Offset: 0x003ABB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060194B9 RID: 103609 RVA: 0x003AD9F4 File Offset: 0x003ABBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194BA RID: 103610 RVA: 0x003ADA01 File Offset: 0x003ABC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194BB RID: 103611 RVA: 0x003ADA0C File Offset: 0x003ABC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Continue)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Continue);
			}
			if (this.RecallId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RecallId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194BC RID: 103612 RVA: 0x003ADA64 File Offset: 0x003ABC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this.Continue)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060194BD RID: 103613 RVA: 0x003ADAB0 File Offset: 0x003ABCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRecallRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194BE RID: 103614 RVA: 0x003ADB00 File Offset: 0x003ABD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194BF RID: 103615 RVA: 0x003ADB0C File Offset: 0x003ABD0C
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RecallId = input.ReadInt32();
					}
				}
				else
				{
					this.Continue = input.ReadBool();
				}
			}
		}

		// Token: 0x040094B3 RID: 38067
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094B4 RID: 38068
		public const int RecallIdFieldNumber = 3;

		// Token: 0x040094B5 RID: 38069
		private int recallId_;

		// Token: 0x040094B6 RID: 38070
		public const int ContinueFieldNumber = 1;

		// Token: 0x040094B7 RID: 38071
		private bool continue_;
	}
}
