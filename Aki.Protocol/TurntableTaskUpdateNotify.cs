using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E5 RID: 5349
	[NetMessage(EMessageId.TurntableTaskUpdateNotify)]
	public sealed class TurntableTaskUpdateNotify : IMessage<TurntableTaskUpdateNotify>, IMessage, IEquatable<TurntableTaskUpdateNotify>, IDeepCloneable<TurntableTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C5DF RID: 116191 RVA: 0x0041DAE4 File Offset: 0x0041BCE4
		[NullableContext(1)]
		public static TurntableTaskUpdateNotify Create()
		{
			return new TurntableTaskUpdateNotify();
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x0601C5E0 RID: 116192 RVA: 0x0041DAEB File Offset: 0x0041BCEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x0601C5E1 RID: 116193 RVA: 0x0041DAEE File Offset: 0x0041BCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TurntableTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C5E2 RID: 116194 RVA: 0x0041DAF5 File Offset: 0x0041BCF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify()
		{
		}

		// Token: 0x0601C5E3 RID: 116195 RVA: 0x0041DAFD File Offset: 0x0041BCFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify(TurntableTaskUpdateNotify other) : this()
		{
			this.turntableTask_ = ((other.turntableTask_ != null) ? other.turntableTask_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C5E4 RID: 116196 RVA: 0x0041DB32 File Offset: 0x0041BD32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TurntableTaskUpdateNotify Clone()
		{
			return new TurntableTaskUpdateNotify(this);
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x0601C5E5 RID: 116197 RVA: 0x0041DB3A File Offset: 0x0041BD3A
		// (set) Token: 0x0601C5E6 RID: 116198 RVA: 0x0041DB42 File Offset: 0x0041BD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityTask TurntableTask
		{
			get
			{
				return this.turntableTask_;
			}
			set
			{
				this.turntableTask_ = value;
			}
		}

		// Token: 0x0601C5E7 RID: 116199 RVA: 0x0041DB4B File Offset: 0x0041BD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TurntableTaskUpdateNotify);
		}

		// Token: 0x0601C5E8 RID: 116200 RVA: 0x0041DB59 File Offset: 0x0041BD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TurntableTaskUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TurntableTask, other.TurntableTask) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C5E9 RID: 116201 RVA: 0x0041DB8C File Offset: 0x0041BD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.turntableTask_ != null)
			{
				num ^= this.TurntableTask.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C5EA RID: 116202 RVA: 0x0041DBC8 File Offset: 0x0041BDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C5EB RID: 116203 RVA: 0x0041DBD5 File Offset: 0x0041BDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C5EC RID: 116204 RVA: 0x0041DBDE File Offset: 0x0041BDDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.turntableTask_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.TurntableTask);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C5ED RID: 116205 RVA: 0x0041DC10 File Offset: 0x0041BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.turntableTask_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TurntableTask);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C5EE RID: 116206 RVA: 0x0041DC50 File Offset: 0x0041BE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TurntableTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.turntableTask_ != null)
			{
				if (this.turntableTask_ == null)
				{
					this.TurntableTask = new ActivityTask();
				}
				this.TurntableTask.MergeFrom(other.TurntableTask);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C5EF RID: 116207 RVA: 0x0041DCA4 File Offset: 0x0041BEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C5F0 RID: 116208 RVA: 0x0041DCB0 File Offset: 0x0041BEB0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.turntableTask_ == null)
					{
						this.TurntableTask = new ActivityTask();
					}
					input.ReadMessage(this.TurntableTask);
				}
			}
		}

		// Token: 0x0400A3E3 RID: 41955
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3E4 RID: 41956
		public const int TurntableTaskFieldNumber = 13;

		// Token: 0x0400A3E5 RID: 41957
		private ActivityTask turntableTask_;
	}
}
