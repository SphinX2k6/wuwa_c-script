using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D6 RID: 4310
	[NetMessage(EMessageId.RollBlockCloseGamePlayNotify)]
	public sealed class RollBlockCloseGamePlayNotify : IMessage<RollBlockCloseGamePlayNotify>, IMessage, IEquatable<RollBlockCloseGamePlayNotify>, IDeepCloneable<RollBlockCloseGamePlayNotify>, IBufferMessage
	{
		// Token: 0x06016FE6 RID: 94182 RVA: 0x00356518 File Offset: 0x00354718
		[NullableContext(1)]
		public static RollBlockCloseGamePlayNotify Create()
		{
			return new RollBlockCloseGamePlayNotify();
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x06016FE7 RID: 94183 RVA: 0x0035651F File Offset: 0x0035471F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x06016FE8 RID: 94184 RVA: 0x00356522 File Offset: 0x00354722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockCloseGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x06016FE9 RID: 94185 RVA: 0x00356529 File Offset: 0x00354729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify()
		{
		}

		// Token: 0x06016FEA RID: 94186 RVA: 0x00356531 File Offset: 0x00354731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify(RollBlockCloseGamePlayNotify other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FEB RID: 94187 RVA: 0x00356556 File Offset: 0x00354756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockCloseGamePlayNotify Clone()
		{
			return new RollBlockCloseGamePlayNotify(this);
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x06016FEC RID: 94188 RVA: 0x0035655E File Offset: 0x0035475E
		// (set) Token: 0x06016FED RID: 94189 RVA: 0x00356566 File Offset: 0x00354766
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

		// Token: 0x06016FEE RID: 94190 RVA: 0x0035656F File Offset: 0x0035476F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockCloseGamePlayNotify);
		}

		// Token: 0x06016FEF RID: 94191 RVA: 0x0035657D File Offset: 0x0035477D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockCloseGamePlayNotify other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FF0 RID: 94192 RVA: 0x003565AC File Offset: 0x003547AC
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

		// Token: 0x06016FF1 RID: 94193 RVA: 0x003565EB File Offset: 0x003547EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x003565F8 File Offset: 0x003547F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FF3 RID: 94195 RVA: 0x00356601 File Offset: 0x00354801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x00356634 File Offset: 0x00354834
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

		// Token: 0x06016FF5 RID: 94197 RVA: 0x00356672 File Offset: 0x00354872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockCloseGamePlayNotify other)
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

		// Token: 0x06016FF6 RID: 94198 RVA: 0x003566A3 File Offset: 0x003548A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FF7 RID: 94199 RVA: 0x003566AC File Offset: 0x003548AC
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
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088E8 RID: 35048
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088E9 RID: 35049
		public const int IncIdFieldNumber = 12;

		// Token: 0x040088EA RID: 35050
		private int incId_;
	}
}
