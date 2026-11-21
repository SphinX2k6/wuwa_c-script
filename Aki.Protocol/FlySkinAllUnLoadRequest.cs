using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F7 RID: 1527
	[NetMessage(EMessageId.FlySkinAllUnLoadRequest)]
	public sealed class FlySkinAllUnLoadRequest : IMessage<FlySkinAllUnLoadRequest>, IMessage, IEquatable<FlySkinAllUnLoadRequest>, IDeepCloneable<FlySkinAllUnLoadRequest>, IBufferMessage
	{
		// Token: 0x06008DB2 RID: 36274 RVA: 0x0015810D File Offset: 0x0015630D
		[NullableContext(1)]
		public static FlySkinAllUnLoadRequest Create()
		{
			return new FlySkinAllUnLoadRequest();
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06008DB3 RID: 36275 RVA: 0x00158114 File Offset: 0x00156314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x00158117 File Offset: 0x00156317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinAllUnLoadRequest.Descriptor;
			}
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x0015811E File Offset: 0x0015631E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest()
		{
		}

		// Token: 0x06008DB6 RID: 36278 RVA: 0x00158126 File Offset: 0x00156326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest(FlySkinAllUnLoadRequest other) : this()
		{
			this.skinType_ = other.skinType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DB7 RID: 36279 RVA: 0x0015814B File Offset: 0x0015634B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadRequest Clone()
		{
			return new FlySkinAllUnLoadRequest(this);
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x00158153 File Offset: 0x00156353
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x0015815B File Offset: 0x0015635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinType
		{
			get
			{
				return this.skinType_;
			}
			set
			{
				this.skinType_ = value;
			}
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x00158164 File Offset: 0x00156364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinAllUnLoadRequest);
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x00158172 File Offset: 0x00156372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinAllUnLoadRequest other)
		{
			return other != null && (other == this || (this.SkinType == other.SkinType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x001581A0 File Offset: 0x001563A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkinType != 0)
			{
				num ^= this.SkinType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x001581DF File Offset: 0x001563DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x001581EC File Offset: 0x001563EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x001581F5 File Offset: 0x001563F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00158228 File Offset: 0x00156428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkinType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x00158266 File Offset: 0x00156466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinAllUnLoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkinType != 0)
			{
				this.SkinType = other.SkinType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00158297 File Offset: 0x00156497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x001582A0 File Offset: 0x001564A0
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkinType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004586 RID: 17798
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004587 RID: 17799
		public const int SkinTypeFieldNumber = 7;

		// Token: 0x04004588 RID: 17800
		private int skinType_;
	}
}
