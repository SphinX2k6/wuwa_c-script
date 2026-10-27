using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000450 RID: 1104
	[NetMessage(EMessageId.EnterBigWorldInstRequest)]
	public sealed class EnterBigWorldInstRequest : IMessage<EnterBigWorldInstRequest>, IMessage, IEquatable<EnterBigWorldInstRequest>, IDeepCloneable<EnterBigWorldInstRequest>, IBufferMessage
	{
		// Token: 0x0600696B RID: 26987 RVA: 0x000FCD9E File Offset: 0x000FAF9E
		[NullableContext(1)]
		public static EnterBigWorldInstRequest Create()
		{
			return new EnterBigWorldInstRequest();
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600696C RID: 26988 RVA: 0x000FCDA5 File Offset: 0x000FAFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x0600696D RID: 26989 RVA: 0x000FCDA8 File Offset: 0x000FAFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstRequest.Descriptor;
			}
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x000FCDAF File Offset: 0x000FAFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest()
		{
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x000FCDB7 File Offset: 0x000FAFB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest(EnterBigWorldInstRequest other) : this()
		{
			this.enterBigWorldInstContext_ = ((other.enterBigWorldInstContext_ != null) ? other.enterBigWorldInstContext_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x000FCDEC File Offset: 0x000FAFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstRequest Clone()
		{
			return new EnterBigWorldInstRequest(this);
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x06006971 RID: 26993 RVA: 0x000FCDF4 File Offset: 0x000FAFF4
		// (set) Token: 0x06006972 RID: 26994 RVA: 0x000FCDFC File Offset: 0x000FAFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext EnterBigWorldInstContext
		{
			get
			{
				return this.enterBigWorldInstContext_;
			}
			set
			{
				this.enterBigWorldInstContext_ = value;
			}
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x000FCE05 File Offset: 0x000FB005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstRequest);
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x000FCE13 File Offset: 0x000FB013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstRequest other)
		{
			return other != null && (other == this || (object.Equals(this.EnterBigWorldInstContext, other.EnterBigWorldInstContext) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x000FCE48 File Offset: 0x000FB048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.enterBigWorldInstContext_ != null)
			{
				num ^= this.EnterBigWorldInstContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x000FCE84 File Offset: 0x000FB084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x000FCE91 File Offset: 0x000FB091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x000FCE9A File Offset: 0x000FB09A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterBigWorldInstContext_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EnterBigWorldInstContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x000FCECC File Offset: 0x000FB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.enterBigWorldInstContext_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnterBigWorldInstContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x000FCF0C File Offset: 0x000FB10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.enterBigWorldInstContext_ != null)
			{
				if (this.enterBigWorldInstContext_ == null)
				{
					this.EnterBigWorldInstContext = new EnterBigWorldInstContext();
				}
				this.EnterBigWorldInstContext.MergeFrom(other.EnterBigWorldInstContext);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x000FCF60 File Offset: 0x000FB160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x000FCF6C File Offset: 0x000FB16C
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
					if (this.enterBigWorldInstContext_ == null)
					{
						this.EnterBigWorldInstContext = new EnterBigWorldInstContext();
					}
					input.ReadMessage(this.EnterBigWorldInstContext);
				}
			}
		}

		// Token: 0x040039F3 RID: 14835
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F4 RID: 14836
		public const int EnterBigWorldInstContextFieldNumber = 10;

		// Token: 0x040039F5 RID: 14837
		private EnterBigWorldInstContext enterBigWorldInstContext_;
	}
}
